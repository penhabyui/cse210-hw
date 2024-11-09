using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter = "";
        string sign = "";
        {
           if (number >= 90)
            {   
                int average = number % 10;
                {
                    if (average >= 7)
                    {
                        letter = "A"; 
                    }
                    else if (average <= 3)
                    {
                        letter ="A";
                        sign = "-";
                    }
                }
            }
            else if (number >= 80)
            {
                int average = number % 10;
                {
                    if (average >= 7)
                    {
                        letter = "B";
                        sign = "+";  
                    }
                    else if (average <= 3)
                    {
                        letter ="B";
                        sign = "-";
                    }
                else 
                    {
                    letter = "B";
                    }
                }
            }
            else if (number >= 70)
            {
                int average = number % 10;
                {
                    if (average >= 7)
                    {
                        letter = "C";
                        sign = "+";
                    }
                    else if (average <= 3)
                    {
                        letter ="C";
                        sign = "-";
                    }
                else 
                    {
                    letter = "C";
                    }
                }
            }
            else if (number >= 60)
            {
                int average = number % 10;
                {
                    if (average >= 7)
                    {
                        letter = "D";
                        sign = "+";
                    }
                    else if (average <= 3)
                    {
                        letter ="D";
                        sign = "-";
                    }
                else 
                    {
                    letter = "D";
                    }
                }
            }
            else
            {
            letter = "F";
            }
        }
            Console.WriteLine($"Your grade is: {letter+sign}");
        { 
            if (number > 70)
            {
                Console.WriteLine($"Congratulations! You have passed!");
            }
            else if (number < 70)
            {
                Console.WriteLine($"Sorry, you have not passed! Keep trying and will be better next time.");
            }
        }

    }
}

    