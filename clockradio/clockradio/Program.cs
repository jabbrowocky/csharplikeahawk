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
            ClockRadio clockRadio = new ClockRadio("102.1",false);
            
            clockRadio.DisplayTime();
            clockRadio.ChangeTime();
            clockRadio.SetAlarm();
            clockRadio.DisplayAlarm();
            clockRadio.SetRadio();
            Console.ReadLine();
        }
    }
}
