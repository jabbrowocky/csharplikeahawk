using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnDestiny
{
    class Introduction
    {
        public bool pathA;
        public bool pathB;
        public Introduction(bool pathA, bool pathB)
        {
            this.pathA = pathA;
            this.pathB = pathB;
            DisplayIntroduction();
        }

        public void DisplayIntroduction()
        {
            Console.WriteLine("The Day devCodeCamp Stood Still \n");
            Console.ReadKey();
            Console.WriteLine("A Choose Your Own Destiny Adventure by Erik White\n\n");
            Console.ReadKey();
            Console.WriteLine(" It is a day, like any other at the Camp de la DevCode. You arrive at the Pritzlaff building and head \nto the elevator, weary from a heavy night of drinking and trying to forget how much you learned the previous day.\nYou slept poorly, tossing and turning, waking up several times, and now you have to cram a month's worth\nof information into several hours. However, as you approach the classroom door, something feels off, the usual\nmirth of the early risers you've gotten to know as Team Cobalt is non-existant, replaced by fear, panic\nand a grim sadness.  On the floor lies Mike, placed almost whimsically on his lifeless chest is a single\nPikachu Pokemon card with a symbol, recognizable as an octathope, written on it in sharpie .");
            Console.ReadKey();
            
        }
    }
}
