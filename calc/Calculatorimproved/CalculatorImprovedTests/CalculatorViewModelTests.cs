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
        public void CalculatorVM_RemoveLastChar_Eqauls()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            string result = calculatorViewModel.RemoveLastChar("3502");
            Assert.Equal("350", result);
        }
        [Fact]
        public void CalculatorVM_RemoveLastChar_NotEqauls()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            string result = calculatorViewModel.RemoveLastChar("35024");
            Assert.NotEqual("350", result);
        }
        [Fact]
        public void CalculatorVM_Delete_Eqauls()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            string result = calculatorViewModel.Delete();
            Assert.Equal("0", result);
        }
        [Fact]
        public void CalculatorVM_Delete_NotEqauls()
        {
            Calculatorimproved.CalculatorViewModel calculatorViewModel = new Calculatorimproved.CalculatorViewModel();
            string result = calculatorViewModel.Delete();
            Assert.NotEqual("", result);
        }
    }
}
