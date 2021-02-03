using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Calculatorimproved
{
    public class CalculatorViewModel
    {
        internal bool operationp = false;
        string result;
        string _operators = "";
        double _value = 0;
        string _fullinput;

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
        public string RemoveLastChar(string input)
        {
            if (input == "0" || input.Length == 1)
            {
                input = "";
            }
            else
            {
                input = input.Remove(input.Length - 1);
            }
            return input;
        }
        public string Delete()
        {
            return "0";
        }
    }
}
