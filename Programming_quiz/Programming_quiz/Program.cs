using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the \"Programming Interactive Quiz\"! \nChoose correct by typing number of correct answer from multiple-choice questions about programming.");
            Console.WriteLine("For one correct answer you receive 1 point!\nFor wrong choice You receive -1 point\nPress any key to start.");
            Console.ReadKey();
            Console.WriteLine("Good luck!");

            var score = 0.0;

            while (true)
            {
                Console.WriteLine("\nWhich programming languages is used for Frontend development?");
                Console.Write("1. C++\n2. Java\n3. Assembler\n4. Javascript\n: ");
                var answer_1 = Console.ReadLine();

                try
                {
                    var number_1 = double.Parse(answer_1);
                    if (number_1 >= 1 && number_1 <= 4)
                    {
                        if (number_1 == 4)
                        {
                            score += 1;
                            break;
                        }

                        else
                        {
                            score -= 1;
                            break;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Please choose available number.");
                        continue;
                    }


                }
                catch (FormatException)
                {

                    Console.WriteLine("That is not valid input.");
                    continue;
                }
            }

            while (true)
            {


                Console.WriteLine("\nWhich of the following is low-level programming language?");
                Console.Write("1. Assembler\n2. C#\n3. Python\n4. Ruby\n: ");
                var answer_2 = Console.ReadLine();

                try
                {
                    var number_2 = double.Parse(answer_2);
                    if (number_2 >= 1 && number_2 <= 4)
                    {
                        if (number_2 == 1)
                        {
                            score += 1;
                            break;
                        }

                        else
                        {
                            score -= 1;
                            break;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Please choose available number.");
                        continue;
                    }


                }
                catch (FormatException)
                {

                    Console.WriteLine("That is not valid input.");
                    continue;
                }
            }

            while (true)
            {
                Console.WriteLine("\nIs this statement true: \"HTML is a programming language\"?");
                Console.Write("1. True\n2. False\n: ");
                var answer_3 = Console.ReadLine();

                try
                {
                    var number_3 = double.Parse(answer_3);
                    if (number_3 >= 1 && number_3 <= 2)
                    {
                        if (number_3 == 2)
                        {
                            score += 1;
                            break;
                        }

                        else
                        {
                            score -= 1;
                            break;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Please choose available number.");
                        continue;
                    }


                }
                catch (FormatException)
                {

                    Console.WriteLine("That is not valid input.");
                    continue;
                }
            }

            Console.WriteLine("Your score is: " + score + "\nPress any button to quit.");
            Console.ReadKey();
        }
    }
}
