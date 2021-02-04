using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Calculatorimproved.Helpers;

namespace Calculatorimproved
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        internal bool operationp = false;
        private string result;
        private string _operators = "";
        private double _value = 0;
        private string _fullinput;
        private string _inputText = "0";
        private string _fullText;
        private readonly RelayCommand _valueButtonCommand;
        private readonly RelayCommand _operatorButtonCommand;
        private readonly RelayCommand _eqaulsButtonCommand;
        private readonly RelayCommand _deleteButtonCommand;
        private readonly RelayCommand _lastButtonCommand;
        public event PropertyChangedEventHandler PropertyChanged;

        public CalculatorViewModel()
        {
            _valueButtonCommand = new RelayCommand(ClickValueButton);
            _operatorButtonCommand = new RelayCommand(ClickOperatorButton);
            _eqaulsButtonCommand = new RelayCommand(ClickEqaulsButton);
            _deleteButtonCommand = new RelayCommand(ClickDeleteButton);
            _lastButtonCommand = new RelayCommand(ClickLastButton);
        }
        public void ClickOperatorButton(object parameter)
        {
            string[] operators = new string[4] { "+", "-", "*", "/" };
            if(operators.Contains(parameter.ToString()))
            {
                operationp = true;
                FullText += Get(parameter.ToString(), Convert.ToDouble(InputText));
            }
            else
            {
                return;
            }

        }
        public void ClickValueButton(object parameter)
        {
            int value;
            bool isnumeric = int.TryParse(parameter.ToString(),out value);
            if(isnumeric == false)
            {
                return;
            }
            if (InputText == "0" || operationp == true)
            {
                InputText = "";
            }
            operationp = false;
            InputText += parameter;
        }

        private void ClickEqaulsButton(object parameter)
        {
            InputText = Calc(InputText);
            FullText = "";
        }

        public void ClickDeleteButton(object parameter)
        {
            InputText = "0";
            FullText = "";
        }

        public void ClickLastButton(object parameter)
        {
            if (InputText == "0" || InputText.Length == 1)
            {
                InputText = "";
            }
            else
            {
                InputText = InputText.Remove(InputText.Length - 1);
            }
        }

        public RelayCommand ValueButtonCommand
        {
            get { return _valueButtonCommand; }
        }
        public RelayCommand OperatorButtonCommand
        {
            get { return _operatorButtonCommand; }
        }
        public RelayCommand EqaulsButtonCommand
        {
            get { return _eqaulsButtonCommand; }
        }
        public RelayCommand DeleteButtonCommand
        {
            get { return _deleteButtonCommand; }
        }
        public RelayCommand LastButtonCommand
        {
            get { return _lastButtonCommand; }
        }
        public string InputText
        {
            get { return _inputText; }
            set { _inputText = value; RaisePropertyChanged(); }
        }
        public string FullText
        {
            get { return _fullText; }
            set { _fullText = value; RaisePropertyChanged(); }
        }

        public string Get(string operation, double value)
        {
            _operators = operation;
            _value = value;
            _fullinput = _value + " " + _operators; 
            return _fullinput;
        }

        public string Calc(string value2)
        {
            switch (_operators)
            {
                case "+":
                    result = (_value + double.Parse(value2)).ToString();
                    break;
                case "-":
                    result = (_value - double.Parse(value2)).ToString();
                    break;
                case "/":
                    result = (_value / double.Parse(value2)).ToString();
                    break;
                case "*":
                    result = (_value * double.Parse(value2)).ToString();
                    break;
                default:
                    break;
            }
            return result;
        }

        protected void RaisePropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
