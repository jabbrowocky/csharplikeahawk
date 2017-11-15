using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clockradio
{
    class ClockRadio
    {
        public string time;
        public string radioStation;
        public bool alarm;
        public string alarmTime;

        public ClockRadio(string radioStation, bool alarm)
        {
            Console.WriteLine("Enter time:");
            time = Console.ReadLine();
            this.radioStation = radioStation;
            this.alarm = alarm;
            
        }

        public void ChangeTime()
        {
            Console.WriteLine("What is the new time?");
            string newTime = Console.ReadLine();
            time = newTime;
            DisplayTime();
        }

        public void DisplayTime()
        {
            Console.WriteLine("The current time is " + time + ".");            
        }
        public void SetAlarm()
        {
            Console.WriteLine("Input a time for your alarm to go off");
            string newAlarmTime = Console.ReadLine();
            alarmTime = newAlarmTime;
            alarm = true;
            

        }
        public void DisplayAlarm()
        {
            if (alarm == true)
            {
                Console.WriteLine("Your alarm has successfully been set to: " + alarmTime);
            }else
            {
                return;
            }
        }
        public void SetRadio()
        {
            Console.WriteLine("Would you like to change your radio station? y or n?\n The station is currently set to:" + radioStation);
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("What would you like to change the radio station to?");
                radioStation = Console.ReadLine();
                Console.WriteLine("Your radio has been set to: " + radioStation);
            }else
            {
                SetRadio();
            }
        }
        
    }
}
