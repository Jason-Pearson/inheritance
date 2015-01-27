using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Hero
    {
        //Private Properties 
        private bool bravery = true;
        private int health;
        private int smarts;
        private string gender;

        //Constructor class*******************************
        public Hero(int health, int smarts, string gender)
        {
            this.health = health;
            this.smarts = smarts;
            this.gender = gender;
        }

        public void doesGoodThings()
        {
            Console.WriteLine("Hero does good things...yeah...");
        }
    }
}
