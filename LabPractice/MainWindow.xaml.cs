/// Week 5 Lab 1
///
/// @author: Julian Trupe
/// Date:  September 27, 2021
///
/// Problem Statement: Write a GUI using WPF which takes a first and last name and translates to pig latin
/// 
/// Overall Plan:
/// 1) Make two text boxes and a button
/// 2) get names from text boxes
/// 3) click button to translate names to pig latin
/// 4) Display translated name to user in a message box
/// 

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

namespace Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            float celsiusTemp = float.Parse(celsiusTextBox.Text);
            float fahrenheitTemp = convertCtoF(celsiusTemp);
            fahrenheitTextBox.Text = fahrenheitTemp.ToString();

            if(fahrenheitTemp >= 90)
            {
                myFirstCanvas.Background = Brushes.Red;
            } else if (fahrenheitTemp >= 80 && fahrenheitTemp < 90)
            {
                myFirstCanvas.Background = Brushes.Yellow;
            } else if (fahrenheitTemp < 80 && fahrenheitTemp >= 65)
            {
                myFirstCanvas.Background = Brushes.Green;
            } else
            {
                myFirstCanvas.Background = Brushes.Blue;
            }
        }

        static float convertCtoF(float degreesC)
        {
            float degreesF = (9 * degreesC / 5) + 32;
            return degreesF;
        }
    }
}
