// -----------------------------------------------------------------------
// <copyright file="RelayCommand.cs" company="Sage CH">
// Copyright (c) Sage CH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Calculatorimproved.Helpers
{
    using System;
    using System.Windows.Input;

    /// <summary>
    /// relay command.
    /// </summary>
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// the execute action.
        /// </summary>
        private readonly Action<object> _executeAction;

        /// <summary>
        /// the can execute predicate.
        /// </summary>
        private readonly Predicate<object> _canExecute;

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand"/> class.
        /// </summary>
        /// <param name="executeAction">The execute action.</param>
        /// <param name="canExecute">Detect if a action can execute.</param>
        public RelayCommand(Action<object> executeAction, Predicate<object> canExecute = null)
        {
            _executeAction = executeAction;
            _canExecute = canExecute;
        }

        /// <summary>
        /// Event if Execute is enabled.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        /// <summary>
        /// execute the parameter.
        /// </summary>
        /// <param name="parameter">the parameter.</param>
        public void Execute(object parameter) => _executeAction(parameter);

        /// <summary>
        /// can the execute.
        /// </summary>
        /// <param name="parameter">the parameter.</param>
        /// <returns>true if the can execute, otherwise false.</returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute?.Invoke(parameter) ?? true;
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
