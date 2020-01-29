using System;

namespace Lab8Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"James", "Shamita", "Erwin"};
            //names.SetValue("James", 1);
            //names.SetValue("Shamita", 1);
            //names.SetValue("Erwin", 1);


            string[] college = {"MSU", "Wayne State", "Lawrence Tech"};
            string[] themeSong = {"Long, Long Way from Home by Foreigner", "Survivor by Destiny's Child", "Get Ready by The Temptations"};
            string[] gender = { "male", "female", "male" };

            string end = "y";
            while (end == "y")
            {
                int i = -1;
                string input;
                while (i == -1)
                {
                    input = GetUserInput("Please enter 1-3 to find out about a student");
                    try
                    {
                        i = int.Parse(input);
                        if (i <= 3 && i >= 1)
                        {
                            i = int.Parse(input) - 1;
                        }
                        else
                        {
                            i = -1;
                        }
                    }

                    catch (FormatException)
                    {
                        if (Array.IndexOf(names, input) <= 2 && Array.IndexOf(names, input) >= 0)
                        {
                            i = Array.IndexOf(names, input);
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                Console.WriteLine($"Student {i + 1} is {names[i]}. What would you like to know about {names[i]}?");
                int caseSwitch = 0;
                while (caseSwitch == 0)
                {

                    try
                    {
                        caseSwitch = int.Parse(GetUserInput("1. College 2. Theme Song 3. Gender"));
                        if (caseSwitch <= 3 && caseSwitch >= 1)
                        {
                            switch (caseSwitch)
                            {
                                case 1:
                                    Console.WriteLine($"{names[i]} attended {college[i]}.");
                                    break;
                                case 2:
                                    Console.WriteLine($"{names[i]} choice {themeSong[i]} as their theme song.");
                                    break;
                                case 3:
                                    Console.WriteLine($"{names[i]} is a {gender[i]}");
                                    break;
                            }
                        }
                        else
                        {
                            caseSwitch = 0;
                            Console.WriteLine("That number is outside of the 3 options");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid Input. Please enter 1-3");
                    }
                }
                end = "";

                Console.WriteLine("Would you like to continue? [y/n]");

                end = Console.ReadLine().ToLower();

                while (end != "y" && end != "n")

                {

                    Console.WriteLine("Please enter [y/n].");

                    end = Console.ReadLine();

                }
            }
            Console.WriteLine("Goodbye");
        }


        static string GetUserInput(string message)

        {

            Console.WriteLine(message);

            return Console.ReadLine();

        }

    }
}
