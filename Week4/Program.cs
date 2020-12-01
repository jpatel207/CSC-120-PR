using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
            Test2();
            TestNum();
        }

        private static void Test1()
        {
            var cleanedRoom = true;
            var didHomework = false;
            if (cleanedRoom && didHomework)
            {
                Console.WriteLine("You can go out");
            }
            else
            {
                Console.WriteLine("No, you can't go out");
            }
        }
        private static void Test2()
        {
            var walking = false;
            var carIsAvailable = false;
            if (walking || carIsAvailable)
            {
                Console.WriteLine("You can go out");
            }
            else
            {
                Console.WriteLine("No, you can't go out");
            }
        }

        private static void TestNum()
        {
            var score = 10; // Try -10 and 110
            if (score < 0 || score > 100)
            {
                Console.WriteLine("Score has an illegal value.");
            }
            if (score >= 0 && score <= 100)
            {
                Console.WriteLine("Score is in the range 0-100");
            }
        }

        private static void TestNot()
        {
            var homeworkDone = false;
            if (!homeworkDone)
            {
                Console.WriteLine("Sorry, you can't go out!");
            }
        }
    }
}