using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Calculatorimproved
{
    class CalculatorViewModel
    {
        internal bool operationp = false;
        string result;
        string _operators = "";
        double _value = 0;
        string _fullinput;

        public string Get(string op, double vl)
        {
            _operators = op;
            _value = vl;
            _fullinput = _value + " " + _operators; 
            return _fullinput;
        }
        public string Calc(string vl)
        {
            
            switch (_operators)
            {
                case "+":
                    result = (_value + double.Parse(vl)).ToString();
                    break;
                case "-":
                    result = (_value - double.Parse(vl)).ToString();
                    break;
                case "/":
                    result = (_value / double.Parse(vl)).ToString();
                    break;
                case "*":
                    result = (_value * double.Parse(vl)).ToString();
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
