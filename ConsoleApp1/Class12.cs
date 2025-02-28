using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class12
    {
       
            int hour;
            int minute;
            int second;
            public Class12()
            {
                hour = 12;
                minute = 0;
                second = 0;
            }
            public Class12(int hour, int minute, int second)
            {
                hour = (hour >= 0 && hour < 24) ? hour : 0;
                minute = (minute >= 0 && minute < 60) ? minute : 0;
                second = (second >= 0 && second < 60) ? second : 0;
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


