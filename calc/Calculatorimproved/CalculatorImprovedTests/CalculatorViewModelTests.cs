using System;
using Xunit;

namespace CalculatorImprovedTests
{
    public class CalculatorViewModelTests
    { 
        [Fact]
        public void CalculatorVM_CalcAdd_Equals()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            calculatorViewModel.Get("+", 5);
            string result = calculatorViewModel.Calc("5");
            Assert.Equal("10", result);
        }
        [Fact]
        public void CalculatorVM_CalcAdd_NotEquals()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            calculatorViewModel.Get("+", 6);
            string result = calculatorViewModel.Calc("5");
            Assert.NotEqual("10", result);
        }

        [Fact]
        public void CalculatorVM_CalcRemove_Equals()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            calculatorViewModel.Get("-", 5);
            string result = calculatorViewModel.Calc("3");
            Assert.Equal("2", result);
        }
        [Fact]
        public void CalculatorVM_CalcRemove_NotEquals()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            calculatorViewModel.Get("-", 8);
            string result = calculatorViewModel.Calc("3");
            Assert.NotEqual("2", result);
        }
        [Fact]
        public void CalculatorVM_CalcMultiply_Eqauls()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            calculatorViewModel.Get("*", 5);
            string result = calculatorViewModel.Calc("5");
            Assert.Equal("25", result);
        }
        [Fact]
        public void CalculatorVM_CalcMultiply_NotEqauls()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            calculatorViewModel.Get("*", 10);
            string result = calculatorViewModel.Calc("5");
            Assert.NotEqual("25", result);
        }
        [Fact]
        public void CalculatorVM_Calcdivision_Equals()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            calculatorViewModel.Get("/", 10);
            string result = calculatorViewModel.Calc("5");
            Assert.Equal("2", result);
        }
        [Fact]
        public void CalculatorVM_Calcdivision_NotEquals()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            calculatorViewModel.Get("/", 10);
            string result = calculatorViewModel.Calc("2");
            Assert.NotEqual("2", result);
        }
        [Fact]
        public void CalculatorVM_Get_Eqauls()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            string result = calculatorViewModel.Get("+", 5);
            Assert.Equal("5 +", result);
        }
        [Fact]
        public void CalculatorVM_Get_NotEqauls()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            string result = calculatorViewModel.Get("/", 5);
            Assert.NotEqual("5 +", result);
        }
        [Fact]
        public void CalculatorVM_ClickLastButton_Eqauls()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            calculatorViewModel.InputText = "33002";
            object parameter = 0;
            calculatorViewModel.ClickLastButton(parameter);
            Assert.Equal("3300", calculatorViewModel.InputText);
        }      
        [Fact]
        public void CalculatorVM_ClickLastButton_NotEqauls()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            calculatorViewModel.InputText = "33002";
            object parameter = 0;
            calculatorViewModel.ClickLastButton(parameter);
            Assert.NotEqual("330", calculatorViewModel.InputText);
        }     
        [Fact]
        public void CalculatorVM_ClickDeleteButton_Eqauls()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            calculatorViewModel.InputText = "5";
            calculatorViewModel.FullText = "1+2+4";
            object parameter = 0;
            calculatorViewModel.ClickDeleteButton(parameter);
            Assert.Equal("0", calculatorViewModel.InputText);
            Assert.Equal("", calculatorViewModel.FullText);
        }
        [Fact]
        public void CalculatorVM_ClickDeleteDelete_NotEqauls()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            object parameter = 0;
            calculatorViewModel.InputText = "5";
            calculatorViewModel.FullText = "1+2+4";
            calculatorViewModel.ClickDeleteButton(parameter);
            Assert.NotEqual("", calculatorViewModel.InputText);
            Assert.NotEqual("0", calculatorViewModel.FullText);
        }
        [Fact]
        public void CalculatorVM_ClickValueButton_Eqauls()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            object parameter = 5;
            calculatorViewModel.ClickValueButton(parameter);
            Assert.Equal("5", calculatorViewModel.InputText);
        }
        [Fact]
        public void CalculatorVM_ClickValueButton_NotEqauls()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            object parameter = 5;
            calculatorViewModel.ClickValueButton(parameter);
            Assert.NotEqual("6", calculatorViewModel.InputText);
        }
        [Fact]
        public void CalculatorVM_ClickOperatorButton_Eqauls()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            object parameter = "+";
            calculatorViewModel.InputText = "5";
            calculatorViewModel.ClickOperatorButton(parameter);
            Assert.Equal("5 +", calculatorViewModel.FullText);
        }
        [Fact]
        public void CalculatorVM_ClickOperatorButton_NotEqauls()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            object parameter = "+";
            calculatorViewModel.InputText = "5";
            calculatorViewModel.ClickOperatorButton(parameter);
            Assert.NotEqual("5 /", calculatorViewModel.FullText);
        }
        [Fact]
        public void CalculatorVM_ClickEqaulsButton_Eqauls()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            object parameter = 0;
            calculatorViewModel.InputText = "5";
            calculatorViewModel.Get("*", 5);
            calculatorViewModel.ClickEqaulsButton(parameter);
            Assert.Equal("25", calculatorViewModel.InputText);
            Assert.Equal("", calculatorViewModel.FullText);
        }

        [Fact]
        public void CalculatorVM_CalcAddWithNull_Equals()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            calculatorViewModel.Get("+", 5);
            string result = calculatorViewModel.Calc(null);
            Assert.Equal("0", result);
        }
        [Fact]
        public void CalculatorVM_CalcRemoveWithNull_Equals()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            calculatorViewModel.Get("-", 5);
            string result = calculatorViewModel.Calc(null);
            Assert.Equal("0", result);
        }
        [Fact]
        public void CalculatorVM_CalcMultiplyWithNull_Eqauls()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            calculatorViewModel.Get("*", 5);
            string result = calculatorViewModel.Calc(null);
            Assert.Equal("0", result);
        }
        [Fact]
        public void CalculatorVM_CalcdivisionWithNull_Equals()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            calculatorViewModel.Get("/", 10);
            string result = calculatorViewModel.Calc(null);
            Assert.Equal("0", result);
        }
        [Fact]
        public void CalculatorVM_GetWithNull_Eqauls()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            string result = calculatorViewModel.Get(null, 5);
            Assert.Equal("", result);
        }
    }
}
