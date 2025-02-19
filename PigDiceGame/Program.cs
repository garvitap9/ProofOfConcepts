using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Pig Dice Game!");
            PigDiceLogic pigDiceLogic = new PigDiceLogic();
            pigDiceLogic.BeginTheGame();
        }
    }
}
