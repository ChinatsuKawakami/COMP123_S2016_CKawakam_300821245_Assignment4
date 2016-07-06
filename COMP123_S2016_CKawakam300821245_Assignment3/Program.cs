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
 * Description: This program display the result of two dices sum and roll them 36000 times
 * version 0.0.2 - created loop to display sum of two dices
 */
namespace COMP123_S2016_CKawakam300821245_Assignment4
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
            //create object of class Randome
            Random dice = new Random();

            
            int []sum = new int[36000];
            
            List <int>dimentional= new List<int>();

            for(int time = 0;time<36000;time++)
            {
                int firstDice = dice.Next(1, 7);
                int secondDice = dice.Next(1, 7);
                sum [time]= firstDice + secondDice;
          
                dimentional.Add(sum[time]);
            }

           
                foreach (var item in dimentional)
                {

                    Console.WriteLine("Sum" + item);

                }

            

        }
    }
}
