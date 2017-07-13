
//Leonard Mabele 
//C sharp script for Calculator App
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Calculator
{
    public partial class MainPage : PhoneApplicationPage
    {

        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        // Simple button Click event handler to take us to the second page
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/GamePage.xaml", UriKind.Relative));
        }

        private void Button_Click_Num(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "0" || (operation_pressed))
                textBox1.Text = "";
            Button b = (Button)sender;

            operation_pressed = false;
            textBox1.Text += b.Content.ToString();

        }

        private void operator_click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            operation = b.Content.ToString();
            value = Double.Parse(this.textBox1.Text);
            operation_pressed = true;
            textBox1.Text = value + "\n" + operation;
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            switch (operation)
            {
                case "+":
                    textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void Button_Cancel(object sender, RoutedEventArgs e)
        {
            value = 0;
            this.textBox1.Text = "0";
        }

        private void button20_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button19_Click(object sender, RoutedEventArgs e)
        {

        }

        private void decimalPlace_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }
    }
}