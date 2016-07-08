using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Date: 7th July 2016
 * Author: Chinatsu Kawakami
 */
namespace COMP123_S2016_Lab4_W8_
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;

           try 
	      {	        
		 Console.WriteLine("Enter an Integer: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an Integer: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result: {0:f2}" + Divide(firstNumber, secondNumber));
	}
	catch(FormatException)
	{

        Console.WriteLine("Error: Please enter integer");
     //   Console.WriteLine(exception.Message);
	}
     catch(OverflowException)
           {
               Console.WriteLine("Error: Number too long");
               Console.WriteLine("Please enter an integer smaller than 2,147,483,647");
     }
           
        }

        private static float Divide(int numerator,int denominator)
        {

          
            try
            {
               float result = Convert.ToSingle(numerator) / Convert.ToSingle(denominator);
              
                return result;
                //Console.WriteLine("Result: " + result);

            }// kind if statment 
            catch (Exception exception)// Exception class and exception is object
            {
                Console.WriteLine("Error: " + exception.Message);
                return 0;
            }// kind else statement
      

        }
    }
}
