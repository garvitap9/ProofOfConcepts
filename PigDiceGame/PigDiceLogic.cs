using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame
{
    public class PigDiceLogic
    {
        public void BeginTheGame()
        {
            string enterChoice;
            do
            {
                Random random = new Random();
                int totalScore = 0;
                int turnNumber = 1;
                const int WINNING_SCORE = 20;

                while (totalScore < WINNING_SCORE)
                {
                    int turnScore = 0;
                    Console.WriteLine("TURN: "+ turnNumber);

                    while (true)
                    {
                        Console.Write("Roll or hold? (r/h): ");
                        char choice = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        
                            
                        if (choice == 'r')
                        {
                            int roll = random.Next(1, 7);
                            Console.WriteLine("Die: "+roll);

                            if (roll == 1)
                            {
                                Console.WriteLine("Turn over. No score.\n");
                                break;
                            }

                            turnScore += roll;
                        }

                        
                        if (choice == 'h')
                        {
                            totalScore += turnScore;
                            Console.WriteLine("Score for turn: " + (turnScore), "Total score: "+(totalScore)+"\n");
                            break;
                        }
                        
                    }

                    turnNumber++;
                }

                Console.WriteLine("You finished in "+(turnNumber - 1)+" turns! GAME OVER...");
                Console.WriteLine("Want to play again? (y/n)");
                enterChoice = Console.ReadLine();
            } while (enterChoice == "y" || enterChoice == "Y");
            Console.WriteLine("GAME EXITED!");
        }
    }
}
