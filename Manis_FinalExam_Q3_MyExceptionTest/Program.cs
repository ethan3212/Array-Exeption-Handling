using System;
using static System.Console;

namespace Manis_FinalExam_Q3_MyExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] theArray = { 1.11, 2.22, 3.33, 4.44, 5.55, 6.66, 7.77, 8.88, 9.99, 10.10 };
            int number;
            
            for (int i = 0; i < theArray.Length; i++)
            {
                try
                {
                    WriteLine("Enter an index value of the array (0 - 9): ");
                    number = int.Parse(ReadLine());
                    if (number < 0 || number >= 10)
                        throw (new ApplicationException("Entered index does not exist. Press any key to continue: "));
                    WriteLine("The number at index {0}, is {1}: ", number, theArray[number]);
                    WriteLine(" ");
                }
                catch (ApplicationException e)
                {

                    WriteLine("Error: {0}", e.Message);
                    WriteLine(" ");
                    ReadLine();
                }
            }
        }
    }
}
