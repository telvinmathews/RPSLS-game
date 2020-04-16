using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    class Human : Players
    {
        //member variables (has a)

        //constructor (spawn)

        public Human()
        {
            gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            score = 0;
        }
        //member methods (can do)


        public override void SelectGesture()
        {
            // logic for selecting a gesture

            Console.WriteLine("Choose a gesture");
            foreach (string option in gestures)
            {
                Console.WriteLine(option);
            }
            chosenGesture = Console.ReadLine();

            // what if the player doesnt miss types the gesture?
        }
    }
}
