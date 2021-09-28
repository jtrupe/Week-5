/// Week 5 Lab 1 
///
/// @author: Julian Trupe
/// Date:  September 27, 2021
///
/// Problem Statement: Write a GUI using WPF takes user input for speed and speed limit,
///                    and displays a message about this and change background color to
///                    reflect the relationship between speed limit and user speed
//
/// Overall Plan:
/// 1) Make two text boxes and a button
/// 2) Get numbers from text boxes
/// 3) If/else statements to determine message and bacckground color change
/// 4) Display message and change background color according to (3)
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

        private void goButton_Click(object sender, RoutedEventArgs e)
        {
            int speedLimit = int.Parse(speedLimitTextBox.Text);
            int yourSpeed = int.Parse(yourSpeedTextBox.Text);

            if(yourSpeed > speedLimit + 25)
            {
                speedyCanvas.Background = Brushes.Red;
                statusLabel.Content = "Slow down, there is a heavy penalty for driving at this speed";
            } else if(yourSpeed > speedLimit && yourSpeed <= speedLimit + 25)
            {
                speedyCanvas.Background = Brushes.Yellow;
                statusLabel.Content = "You are driving slightly over the speed limit, there will be a small penalty";
            } else
            {
                speedyCanvas.Background = Brushes.Green;
                statusLabel.Content = "You are driving below the speed limit, carry on";
            }
        }
    }
}