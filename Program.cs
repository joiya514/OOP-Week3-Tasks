using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3Tasks.BL;

namespace Week3Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //||||||||||||||||||||||||||||| TASK1 |||||||||||||||||||||||||||||||||
            //constructor s1 = new constructor();
            //Console.WriteLine(s1.name  +"\n" + s1.mathMarks + "\n" + s1.urduMarks + "\n" + s1.engMarks);

            //||||||||||||||||||||||||||||| Task 2 ||||||||||||||||||||||||||||||||
            //constructor s1 = new constructor("ABC");
            //Console.WriteLine(s1.name);
            //constructor s2 = new constructor(1000);
            //Console.WriteLine(s1.name + "\n" + s1.mathMarks);

            //|||||||||||||||||||||||||||| FOREACH LOOP ||||||||||||||||||||||||||
            //List<string> num = new List<string>() { "1", "2", "3", "hagsdgs", "28712hjbsh#TY^UT%"};
            //foreach(var x in num)
            //{
            //    Console.WriteLine(x);
            //}

            // |||||||||||||||||||||||||||  CLOCKTYPE  TASK  |||||||||||||||||||||
            //clockType starting = new clockType();
            //Console.Write(" Starting Time: ");
            //starting.printTime();

            //clockType hourTime = new clockType(8);
            //Console.Write(" Hour Time: ");
            //hourTime.printTime();

            //clockType minTime = new clockType(8, 10);
            //Console.Write(" Minute Time: ");
            //minTime.printTime();

            //clockType fullTime = new clockType(8, 10, 10);
            //Console.Write(" Full Time: ");
            //fullTime.printTime();

            //fullTime.incSecond();
            //Console.Write(" Full Time(Increment Seconds): ");
            //fullTime.printTime();

            //fullTime.incHour();
            //Console.Write(" Full Time(Increment Hours): ");
            //fullTime.printTime();

            //fullTime.incMinute();
            //Console.Write(" Full Time(Increment Minutes): ");
            //fullTime.printTime();

            //bool flag = fullTime.isEqual(9, 11, 11);
            //Console.WriteLine(" Flag: " + flag);

            //clockType cmp = new clockType(10, 12, 1);
            //flag = fullTime.isEqual(10, 12, 1);
            //Console.WriteLine(" Object Flag: " + flag);

            //||||||||||||||||||||||||||||||||  CHALLENE 1  |||||||||||||||||||||||||||||||||||
            clockType elapTime = new clockType(8, 10, 10);
            Console.Write(" Elapsed Time: ");
            elapTime.printTime();

            clockType remTime = new clockType(8, 10, 10);
            remTime.remainingTime(20,3,30);
            remTime.remainingTime(20,3);
            remTime.remainingTime(20);
            Console.Write(" Remaining Time: ");
            remTime.printTime();

            Console.ReadKey();
        }
    }
}
