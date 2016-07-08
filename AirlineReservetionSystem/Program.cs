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
 * version 0.0.3 - updated program
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
            List<string>seats = new List<string>();
         
      


          

            while(seats.Count<10)
            {
                Console.WriteLine("Enter 1(First Class), 2(Economy Class),and 3(Exit)");
                int number = int.Parse(Console.ReadLine());
                string answer = "";
                int ecoIndex = 0;
            switch(number)
            {
                case 1:
                    if (seats.Count < 5)
                    {
                        seats.Add("First Class");
                        break;
                    }else if(seats.Count>4)
                    {
                        Console.WriteLine("First class seats are full. Do you want to book Economy class seat instead of it? Enter y(es)/n(o)");
                        answer = Console.ReadLine();
                        if (answer == "y")
                        {
                            seats.Add("Economy Class");
                            break;
                        }
                        else if(answer == "n")
                        {
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
                  
                    seats.Insert(5 + ecoIndex, "Economy Class");
                    if(ecoIndex<5)
                    ++ecoIndex;
                    break;
                case 3:
                    break;
            }//end switch
             

           
            }//end while loop


            List<string> assignSeats = new List<string>();
            for (int i = 0; i<10;i++)
            {
                assignSeats[i] = seats.ElementAt(i);
                seats.RemoveAt(i);
            }

            foreach (var item in assignSeats)
            {
                Console.WriteLine(item);
            }

            
           
        }
    }
}
