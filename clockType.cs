using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Tasks.BL
{
    class clockType
    {
        public clockType()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public clockType(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        public clockType(int h, int m)
        {
            hours = h;
            minutes = m;
        }
        public clockType(int h)
        {
            hours = h;
        }
        public void incMinute()
        {
            minutes++;
        }
        public void incHour()
        {
            hours++;
        }
        public void incSecond()
        {
            seconds++;
        }
        public void remainingTime(int h)
        {
            if (minutes != 0)
            {
                hours = 23 - hours;
            }
            else
            {
                hours = 24 - hours;
            }
        }
        public void remainingTime(int h, int m)
        {
            if (seconds != 0)
            {
                minutes = 59 - minutes;
            }
            else
            {
                minutes = 60 - minutes;
            }
        }
        public void remainingTime(int h, int m, int s)
        {
            seconds = 60 - seconds;
        }
        public void printTime()
        {
            Console.WriteLine(hours + " : " + minutes + " : " + seconds);
        }
        public bool isEqual(int h, int m, int s)
        {
            if(hours == h && minutes == m && seconds == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEqual(clockType temp)
        {
            if (hours == temp.hours && minutes == temp.minutes && seconds == temp.seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public int hours;
        public int minutes;
        public int seconds;
    }
}
