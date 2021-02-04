// -----------------------------------------------------------------------
// <copyright file="RelayCommandAsync.cs" company="Sage CH">
// Copyright (c) Sage CH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Calculatorimproved.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;

    /// <summary>
    /// relay command async.
    /// </summary>
    public class RelayCommandAsync : ICommand
    {
        /// <summary>
        /// the can execute.
        /// </summary>
        private readonly Predicate<object> _canExecute;

        /// <summary>
        /// the async execute.
        /// </summary>
        private readonly Func<object, Task> _asyncExecute;

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommandAsync"/> class.
        /// Creates a new command that can always execute.
        /// </summary>
        /// <param name="asyncExecute">The execution logic.</param>
        public RelayCommandAsync(Func<object, Task> asyncExecute)
            : this(asyncExecute, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommandAsync"/> class.
        /// Creates a new command.
        /// </summary>
        /// <param name="asyncExecute">The execution logic.</param>
        /// <param name="canExecute">The execution status logic.</param>
        public RelayCommandAsync(Func<object, Task> asyncExecute, Predicate<object> canExecute)
        {
            _asyncExecute = asyncExecute ?? throw new ArgumentNullException("_asyncExecute");
            _canExecute = canExecute;
        }

        /// <summary>
        /// Event if Execute is enabled.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        public string ToolTip { get; set; }

        /// <summary>
        /// can the execute.
        /// </summary>
        /// <param name="parameter">the parameter.</param>
        /// <returns>true if the can execute, otherwise false.</returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        /// <summary>
        /// execute the parameter.
        /// </summary>
        /// <param name="parameter">the parameter.</param>
        public async void Execute(object parameter)
        {
            await ExecuteAsync(parameter);
        }

        /// <summary>
        /// execute the async.
        /// </summary>
        /// <param name="parameter">the parameter.</param>
        /// <returns>the task.</returns>
        protected virtual async Task ExecuteAsync(object parameter)
        {
            await _asyncExecute(parameter);
        }

        /// <summary>
        /// raise the can execute changed.
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }
    }
}
