﻿//Author of project: SAC SUITS 
// Project created for the NASA Spacesuit User 
//Interface Technologies for Students challenge 
//to aide in their Artemis project - to safely land 
//a man and a woman on the moon in 2024
// Driver class - contains the main method and is 
//the main part of the code 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACSUITSMain
{
    class Driver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the SAC SUITS Design Interface");

            //Menu selection for different programs
            //menu selection will eventually be turned 
            //into buttons on head mounted display 

            Console.WriteLine("Please select a program to be used");
            Console.WriteLine("Please select 0 to exit the menue and go to the home screen display");
            Console.WriteLine("Please select 1 for the Navigation Pprogram");
            Console.WriteLine("Please select 2 for the Science Sampling program");
            Console.WriteLine("Please select 3 for Lighting settings");

            int menuChoice = Convert.ToInt32(Console.ReadLine());

            if (menuChoice == 0)
            {
                //Go to 'Home Screen Display' code 
            }
            else if (menuChoice == 1)
            {
                // Go to 'Navigation' code
            }
            else if (menuChoice == 2)
            {
                // Go to 'Science Sampling' code
            }
            else if (menuChoice == 3)
            {
                //Go to 'Lighting settings' code 
            }
            else
            {
                Console.WriteLine("Please select a "
                     + "program to run, or select 0 "
                     + "to exit the menu and go to the "
                     + "home screen display");
            }
        }
    }
}
