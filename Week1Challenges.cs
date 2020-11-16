using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Week1Challenges
{
    [TestClass]
    public class Week1Challenges
    {
        private object listofDates;

        [TestMethod]
        public void Challenge1()
        {
            string firstName = "Caleb";
            string lastName = "Addie";
            int age = 31;

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
        }

        [TestMethod]
        public void Challenge2()
        {
            string[] myFavs = { "Game of Thrones", "Outlander", "Parks and Rec", "The Last Kingdom" };

            foreach (string show in myFavs)
            {
                Console.WriteLine(show);
            }
        }

        [TestMethod]
        public void Challenge3()
        {
            DateTime now = DateTime.Now;
            DateTime yesterday = new DateTime(2020, 11, 12);

            DateTime[] dates = { now, yesterday };

            List<DateTime> listOfDates = new List<DateTime>();
            listOfDates.AddRange(dates);

            foreach (DateTime pleaseWork in listOfDates)
            {
                Console.WriteLine(pleaseWork);
            }

        }

        [TestMethod]
        public void Challenge4()
        {
            int age = 31;
            int seven = 7;

            int sum = age + seven;
            Console.WriteLine(sum);
            int diff = age - seven;
            Console.WriteLine(diff);
            int prod = age * seven;
            Console.WriteLine(prod);
            int quot = age / seven;
            Console.WriteLine(quot);
            int remainder = age % seven;
            Console.WriteLine(remainder);
        }

        [TestMethod]
        public void Challenge5()
        {
            int hoursSlept = 6;

            if (hoursSlept >= 10)
            {
                Console.WriteLine("Wow! That's a lot of sleep!");
            }
            else if (hoursSlept < 10 && hoursSlept >= 8)
            {
                Console.WriteLine("You should be pretty rested.");
            }
            else if (hoursSlept < 8 && hoursSlept >= 4)
            {
                Console.WriteLine("Bummer!");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }

            switch (hoursSlept)
            {
                case 10:
                case 9:
                    Console.WriteLine("Great!");
                    break;
                case 8:
                case 7:
                    Console.WriteLine("Good!");
                    break;
                case 6:
                case 5:
                    Console.WriteLine("Okay!");
                    break;
                case 4:
                case 3:
                    Console.WriteLine("Bad!");
                    break;
            }
        }

        [TestMethod]
        public void CommitToGit()
        {
            string practice = "Too commit, too commit to git.");
            Console.WriteLine(practice);
        }
    }
}
