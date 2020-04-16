using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    class Computer : Players
    {
        //member variables (has a)

        //constructor (spawn)
        public Computer()
        {
            gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            score = 0;
        }
        //member methods (can do)

        public override void SelectGesture()
        {
            // logic for selecting a gesture at random
            Random random = new Random();
            int index = random.Next(gestures.Count);
            chosenGesture = gestures[index];
            Console.WriteLine(chosenGesture);
        }
    }
}
