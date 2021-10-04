using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Weekly_Assignment_4_Q4
{
    class Calculator
    {
        public void Add(int a, int b)
        {
            try 
            {
                int result = a + b;
                Console.WriteLine("Sum of the 2 numbers: " + result);
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            catch (ArithmeticException e)
            {
                throw e;
            }
            catch (FormatException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public void Subtract(int a, int b)
        {   
            try
            {
                int result = a - b;
                Console.WriteLine("Difference bewtween the 2 numbers: " + result);
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            catch (ArithmeticException e)
            {
                throw e;
            }
            catch (FormatException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Multiply(int a, int b)
        {
            
            try
            {
                int result = a * b;
                Console.WriteLine("Multiplication of the 2 numbers: " + result);
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            catch (ArithmeticException e)
            {
                throw e;
            }
            catch (FormatException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public void Divide(double a, double b)
        { 
            try
            {
                double result = a / b;
                Console.WriteLine("Division of the 2 numbers: " + result);
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            catch (ArithmeticException e)
            {
                throw e;
            }
            catch (FormatException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Remainder(double a, double b)
        {
            try
            {
                double result = a % b;
                Console.WriteLine("Remainder of the 2 numbers: " + result);
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            catch (ArithmeticException e)
            {
                throw e;
            }
            catch (FormatException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Power(double a, double b)
        {
            try
            {
                double result = Math.Pow(a,b);
                Console.WriteLine("Power of the 2 numbers: " + result);
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            catch (ArithmeticException e)
            {
                throw e;
            }
            catch (FormatException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
