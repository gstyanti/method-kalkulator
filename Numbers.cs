using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public  class Numbers
    {
        private float result;

        public int FindMinimum(int number1, int number2)
        {
            /* local variabel declaration */
            int result;

            if (number1 < number2)
                result = number1;
            else
                result = number2;
            return result;
        }
        
        public int FindMinimum(int number1, int number2, float number3) 
        { 

            if (number1 < number2 && number1 < number3) 
                result = number1;
             else if (number2 < number3) 
                result = number2;
            else 
                result = number3;
                return  result; 
        }
        public int FindMaximum(int number1, int number2)
        {
            /* local variabel declaration */
            int result;

            if (number1 > number2)
                result = number1;
            else
                result = number2;
            return result;
        }
        public int FindMakximum(int number1, int number2, float number3)
        {

            if (number1 > number2 && number1 > number3)
                result = number1;
            else if (number2 > number3)
                result = number2;
            else
                result = number3;
            return result;
        }
    }
}
