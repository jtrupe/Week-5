/// Homework 5 Project 2
///
/// @author: Julian Trupe
/// Date:  September 27, 2021
///
/// Problem Statement: Write a program that will calculate the statistics for 8 coin toss
//
/// Overall Plan:
/// 1) Greet the user and explain program
/// 2) Prompt user to enter h or t for the result of coin tosses
/// 3) update counters based on user input
/// 4) calculate percentage of heads and tails
/// 5) Display number of heads/tails and percentage heads/tails
/// 


using System;

namespace hw5project2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] labelsArr = { "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth" };
            int numTails=0, numHeads = 0;
            float percentHeads, percentTails;
            Console.WriteLine("Today we are going to toss some coins");
            Console.WriteLine("Please enter the result of the toss, h or t");

            foreach(string i in labelsArr)
            {
                Console.WriteLine(i + " Toss: ");
                char toss = char.Parse(Console.ReadLine());
                if(toss == 'h')
                {
                    numHeads++;
                } else if(toss == 't')
                {
                    numTails++;
                } else
                {
                    Console.WriteLine("Please enter either h or t and run the program again");
                    break;
                }
            }
            percentHeads = (float)100 * numHeads / 8;
            percentTails = (float)100 * numTails / 8;
            Console.WriteLine("Number of Heads: " + numHeads);
            Console.WriteLine("Number of Tails: " + numTails);
            Console.WriteLine("Percent Heads: " + percentHeads + "%");
            Console.WriteLine("Percent Tails: " + percentTails + "%");

            Console.ReadLine();
        }
    }
}
