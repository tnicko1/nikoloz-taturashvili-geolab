﻿namespace nikoloz_taturashvili_geolab.Homework_1
{
    public class Task8
    {
        public static void Run()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18 && age <= 120) //oldest living person is 116 years old
            {
                Console.WriteLine("You are allowed to vote");
            }
            else if (age >= 0 && age < 18)
            {
                Console.WriteLine("You are not allowed to vote");
            }
            else
            {
                Console.WriteLine("Invalid age, try again");
            }
        }
    }
}