using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class13
    {

        private int hour;
        private int minute;
        private int second;

        public Class13()
        {
            hour = 12;
            minute = 0;
            second = 0;
        }

        public Class13(int h, int m, int s)
        {
            hour = (h >= 0 && h < 24) ? h : 0;
            minute = (m >= 0 && m < 60) ? m : 0;
            second = (s >= 0 && s < 60) ? s : 0;
        }

        public void IncrementTime()
        {
            second++;
            if (second == 60)
            {
                second = 0;
                minute++;
                if (minute == 60)
                {
                    minute = 0;
                    hour++;
                    if (hour == 24)
                    {
                        hour = 0;
                    }
                }
            }
        }

        public void DisplayTime()
        {
            Console.WriteLine($"{hour:D2}:{minute:D2}:{second:D2}");
        }

        public int GetHour()
        {
            return hour;
        }

        public int GetMinute()
        {
            return minute;
        }

        public int GetSecond()
        {
            return second;
        }
    }

}

