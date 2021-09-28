/// Homework 5 Project 1 
///
/// @author: Julian Trupe
/// Date:  September 27, 2021
///
/// Problem Statement: Write a GUI using WPF which calculates BMI based on user input height/weight
//
/// Overall Plan:
/// 1) Make two text boxes, labels and a button
/// 2) Get numbers from text boxes
/// 3) Calculate the BMI from inputs
/// 4) Display a message with the BMI and context text, change background color to reflect BMI range
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

namespace hw5project1
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            float userHeight = float.Parse(heightBox.Text);
            float userWeight = float.Parse(weightBox.Text);
            float userBMI = calculateBMI(userHeight, userWeight);
            string message = "Your BMI is " + Math.Round(userBMI, 1);

            if(userBMI > 26)
            {
                message += ", this is above the healthy range";
                bmiCanvas.Background = Brushes.Yellow;
            } else if(userBMI <= 26 && userBMI >= 15)
            {
                message += ", this is within the healthy range";
                bmiCanvas.Background = Brushes.Green;
            }else
            {
                message += ", this is below the healthy range";
                bmiCanvas.Background = Brushes.Blue;
            }

            MessageBox.Show(message);
        }

        static float calculateBMI(float height, float weight)
        {
            float BMI = (weight * 720) / (height * height);
            return BMI;
        }
    }
}
