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
 * version 0.0.2 - Added while loop and switch
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
            List<string>[]seats = new List<string>[10];

            Console.WriteLine("Enter 1(First Class), 2(Economy Class),and 3(Exit)");
            int number = int.Parse(Console.ReadLine());

            int i = 0;
            while(i<10)
            {
            switch(number)
            {
                case 1:
                    seats[i].Add("First Class");
                    break;
                case 2:
                    seats[i].Add("Economy Class");
                    break;
                case 3:
                    break;
            }//end switch

                i++;
            }//end while loop

        }
    }
}
