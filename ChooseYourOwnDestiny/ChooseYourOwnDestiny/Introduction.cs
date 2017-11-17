using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnDestiny
{
    class Introduction
    {
        private bool pathA;
        private bool pathB;
        private string response;

        public Introduction(bool pathA, bool pathB)
        {
            this.pathA = pathA;
            this.pathB = pathB;
            
            StoryArcer(DisplayIntroduction());
            
        }

        public string DisplayIntroduction()
        {
            
            Console.WriteLine("The Day devCodeCamp Stood Still \n");
            Console.ReadKey();
            Console.WriteLine("A Choose Your Own Destiny Adventure by Erik White\n\n");
            Console.ReadKey();
            Console.WriteLine("  It is a day, like any other at the Camp de la DevCode. You arrive at the Pritzlaff building and head \nto the elevator, weary from a heavy night of drinking and trying to forget how much you learned the previous day.\nYou slept poorly, tossing and turning, waking up several times, and now you have to cram a month's worth\nof information into several hours. However, as you approach the classroom door, something feels off, the usual\nmirth of the early risers you've gotten to know as Team Cobalt is non-existant, replaced by fear, panic\nand a grim sadness.  On the floor lies Mike, placed almost whimsically on his lifeless chest is a single\nPikachu Pokemon card with a symbol, recognizable as an octathope, written on it in sharpie.\nHow do you react?\n");
            Console.WriteLine("  (Option 1) Coward: Run like hell and call the police");
            Console.WriteLine("  (Option 2) Gumshoe: Investigate the scene of the crime\n");
            Console.WriteLine("  So, what's it gonna be? 'coward' or 'gumshoe'?");
            response = Console.ReadLine().ToLower();
            return response;
            

            //Random DiceRoll = new Random();
            //Console.WriteLine(DiceRoll.Next(1, 7));
            //Console.ReadKey();

        }
        public void StoryArcer(string introCapture)
        {
            switch (introCapture)
            {
                case "coward":
                    pathA = true;
                    break;
                case "gumshoe":
                    pathB = true;
                    break;
                default:
                    Console.WriteLine("So, what's it gonna be? 'coward' or 'gumshoe'?");
                    introCapture = Console.ReadLine();
                    StoryArcer(introCapture);
                    break;
            }
            if (pathA == true)
            {
                coward cowardPath = new coward();
            }
            else if (pathB == true)
            {
                gumshoe gumshoePath = new gumshoe();
            }
        }
    }
}
