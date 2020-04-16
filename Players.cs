using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    abstract class Players
    {
        //member variable (Has A).

        public int score;
        public string chosenGesture;
        public List<string> gestures;



        // constructor (spawns).

        public Players()
        {
           
        }

        // methods (can do).

        public abstract void SelectGesture();






    }
}
