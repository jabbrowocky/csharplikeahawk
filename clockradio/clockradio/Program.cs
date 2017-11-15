using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clockradio
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockRadio clockRadio = new ClockRadio("103.7",false);
            
            clockRadio.DisplayTime();
            clockRadio.ChangeTime();
            clockRadio.SetAlarm();
            clockRadio.DisplayAlarm();
            Console.ReadLine();
        }
    }
}
