using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnDestiny
{
    class gumshoe
    {
        public bool gumshoeForkA;
        public bool gumshoeForkB;
        public gumshoe(bool gumshoeForkA, bool gumshoeForkB)
        {
            this.gumshoeForkA = gumshoeForkA;
            this.gumshoeForkB = gumshoeForkB;
            BeginInvestigation();
        }
        public void BeginInvestigation()
        {
            Console.WriteLine("You immediately take control of the situation.  'Guys' you say");
        }
    }
}
