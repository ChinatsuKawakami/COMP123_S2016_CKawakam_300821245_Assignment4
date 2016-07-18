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
 * Date Modified : 8th July 2016
 * Description: This program display the result of two dices sum and roll them 36000 times
 * version 0.0.5 - updated program to show sum of dice
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
            //a:create object of class Randome

            Random dice = new Random();
            //int []sum = new int[36000];
           // List <int>dimentional= new List<int>();

            //int[] dimention = new int[36000]; ;

            int[] tarry = new int[13];
            int sum;
  
            for(int time = 0;time<36000;time++)
            {

          
                int firstDice = dice.Next(1, 7);
                int secondDice = dice.Next(1, 7);
                //b:calculate sum of two dices
               // sum [time]= firstDice + secondDice;
                sum = firstDice + secondDice;
                tarry[sum]++;
                
            }
            
            for(int sumNum = 2;sumNum<13;sumNum++)
            {

                //Console.Write("Time : " + (i+1));
                //Console.WriteLine(" Sum : " + dimention[i]);
                Console.WriteLine("Sum of {0} is {1}" ,sumNum ,tarry[sumNum]);
            }

            Console.WriteLine("Please push Enter key if you want to exit");
            Console.ReadKey();

            /*
           
                foreach (var item in dimentional)
                {
                    int i = 1;
          
                    Console.Write("Time :" + i);
                    if (i <= 36000)
                    {
                        i++;
                    }
                    Console.WriteLine("Sum" + item);
                    

                }
        */
            

        }
    }
}
