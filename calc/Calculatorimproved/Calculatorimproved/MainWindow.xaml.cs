using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculatorimproved
{
    public partial class MainWindow : Window
    {
        Calculator _calculator = new Calculator();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            if(Input_txt.Text == "0" || _calculator.operationp == true)
            {
                Input_txt.Clear();
            }
            _calculator.operationp = false;
            Button b = sender as Button;
            Input_txt.Text += b.Content as string;
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            Input_txt.Text = "0";
        }
        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                _calculator.operationp = true;
              
                FullInput_txt.Text = _calculator.Get(b.Content as string, Convert.ToDouble(Input_txt.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Input_txt.Text = _calculator.Calc(Input_txt.Text);   
                FullInput_txt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Remove_Last_Click(object sender, RoutedEventArgs e)
        {
            
            string input = Input_txt.Text;
            if(input == "0" || input.Length == 1)
            {
                input = "";
            }
            else
            {
                input = input.Remove(input.Length - 1);  
            }

            Input_txt.Text = input;

        }
    }
}
