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

namespace Methods_3___Rekenmachine2_herwerkt_naar_methods
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private float FirstNumber = 0.0f;
        private float SecondNumber = 0.0f;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ReadNumbers(string firstNumberText, string secondNumberText)
        {
            FirstNumber = float.Parse(firstNumberText);
            SecondNumber = float.Parse(secondNumberText);
        }

        // char is een karakter (letter, symbool, cijfer,...)
        private float Calculate(char sign)
        {
            switch (sign)
            {
                case '+':
                    return FirstNumber + SecondNumber;
                case '-':
                    return FirstNumber - SecondNumber;
                case '*':
                    return FirstNumber * SecondNumber;
                case '/':
                    return FirstNumber / SecondNumber;
                default:
                    // Functie method moet altijd een resultaat returnen!
                    return 0.0f;
            }
        }


        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            ReadNumbers(firstNumberTextBox.Text, secondNumberTextBox.Text);
            float resultaat = Calculate('+');
            resultTextBox.Text = resultaat.ToString();
            firstNumberTextBox.Focus();
        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            ReadNumbers(firstNumberTextBox.Text, secondNumberTextBox.Text);
            float resultaat = Calculate('-');
            resultTextBox.Text = resultaat.ToString();
            firstNumberTextBox.Focus();
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            ReadNumbers(firstNumberTextBox.Text, secondNumberTextBox.Text);
            float resultaat = Calculate('*');
            resultTextBox.Text = resultaat.ToString();
            firstNumberTextBox.Focus();
        }

        private void divideButton_Click(object sender, RoutedEventArgs e)
        {
            ReadNumbers(firstNumberTextBox.Text, secondNumberTextBox.Text);
            float resultaat = Calculate('/');
            resultTextBox.Text = resultaat.ToString();
            firstNumberTextBox.Focus();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            firstNumberTextBox.Text = "0";
            secondNumberTextBox.Text = "0";
            resultTextBox.Clear();
            firstNumberTextBox.Focus();
        }
    }
}
