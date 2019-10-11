using System;

namespace Fekr_o_Bekr
{
    class Program
    {
        static void Main(string[] args)
        {
            //Starting
            Console.WriteLine("Hi...");
            Console.Write("Please Press any Key to Start Game!");
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //Setting Random Number 
            Console.Write("Please Enter a Seven Digits ");
                  Random numberRandom =
                      new Random();
                 string number =
                      numberRandom.Next(1000000, 9999999).ToString();

            //Getting Numbers
            ////if User Enter Wrong Number then Program will Return to this Tag
        WrongRepeat:
            ////
            Console.ForegroundColor = 
                ConsoleColor.Black;
            Console.Write("Number: ");
                string guess = 
                     Console.ReadLine();

            //input Length 
            if (guess.Length < 7 || guess.Length > 7)
            {
                Console.Write("Please Enter a ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Seven Digits");
                Console.WriteLine("Number!!!");
                goto WrongRepeat;
            }

            //Text Format of Output
            int counter = 0;
            Console.Write("        ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*******");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Number: ");
            // Arrays for Compare
            string[] numbersUser = new string[7];
            string[] numbersRandom = new string[7];
            //Numbers Checking
            for (int num = 0; num < 7; num++)
            {
                //Using Arry to Compare Digits
                numbersUser[num] = guess.Substring(num, 1);
                numbersRandom[num] = number.Substring(num, 1);

                if (counter == 6)
                {
                    goto finishing;
                }

                //if User Enter Correct Digits
                if (numbersUser[num] == numbersRandom[num])
                {
                    counter++;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write(numbersUser[num]);
                    Console.BackgroundColor = ConsoleColor.White;
                }

                //if User Enter Wrong Digits 
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(numbersUser[num]);
                    Console.BackgroundColor = ConsoleColor.White;
                }
            }
            //Write a Clean Line
            Console.WriteLine();

            //Wrong Input From User And Return at The First of Input State
            goto WrongRepeat;
            //Finish Text
        finishing:
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("                                                         ");
            Console.Write("--------");
            Console.WriteLine();
            Console.Write("                                                        ");
            Console.Write("|You Won!|");
            Console.WriteLine();
            Console.Write("                                                         ");
            Console.Write("--------");



            Console.ReadKey();
        }
    }
}
