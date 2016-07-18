using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * This is driver class
 * Author: Chinatsu Kawakami
 * StudentID:300821245
 * Date: 6th July 2016
 * Date Modified : 6th July 2016
 * Description: This program display kind of Seats in airline
 * version 0.0.5 - updated the way to display if user enter "n" in if-else statement
 */
namespace AirlineReservetionSystem
{
    /**
     * The Maim method for our driver class program
     * @class: program
     */
    class Program
    {
        /**
         * The Main method for our driver class program
         * 
         * @constructor:Main
         * @param {string[]}args
         */
        static void Main(string[] args)
        {
            List <string> seats = new List<string>();





            int ecoCount = 0;
            int firstCount = 0;
            Boolean cont = true;
            while (seats.Count < 10 && cont)
            {
                Console.WriteLine("Enter 1(First Class), 2(Economy Class),and 3(Exit)");
                int number = int.Parse(Console.ReadLine());
                string answer = "";

                switch (number)
                {
                    case 1:
                        if (firstCount < 5)
                        {
                            seats.Add("First Class");
                            firstCount++;
                            break;
                        }
                        else if (firstCount > 4)
                        {
                            Console.WriteLine("First class seats are full. Do you want to book Economy class seat instead of it? Enter y(es)/n(o)");
                            answer = Console.ReadLine();
                            if (answer == "y")
                            {
                                seats.Add("Economy Class");
                                ecoCount++;
                                break;
                            }
                            else if (answer == "n")
                            {
                                Console.WriteLine("Next flight leaves in 3 hours");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Enter y(es) or n(o) ");
                                break;

                            }

                        }
                        break;

                    case 2:
                        if (ecoCount < 5)
                        {
                            seats.Add("Economy Class");
                            ecoCount++;
                            break;
                        }
                        else if (ecoCount > 4)
                        {
                            Console.WriteLine("Economy class seats are full. Do you want to book the First Class seat instead of it? Enter y(es) or n(o)");
                            answer = Console.ReadLine();
                            if (answer == "y")
                            {
                                seats.Add("First class");
                                break;
                            }
                            else if (answer == "n")
                            {
                                Console.WriteLine("Next flight leaves in 3 hours");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please Enter y(es) or n(o)");
                                break;
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Exit");//????
                        cont = false;
                        break;

                }//end switch



            }//end while loop

            if (cont)
            {

                List<string> assignSeats = new List<string>();
                for (int i = 9; i >= 0; i--)
                {
                    assignSeats.Add(seats.ElementAt(i));
                    seats.RemoveAt(i);

                }

                assignSeats.Sort();
                assignSeats.Reverse();

                for (int index = 0; index < 10; index++)
                {

                    Console.WriteLine("Seat" + (index + 1) + ": " + assignSeats[index]);

                }

            }
        }
    }
}

   