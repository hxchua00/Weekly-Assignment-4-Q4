using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Weekly_Assignment_4_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Thread main = new Thread(() => { UserMenu(); });
                main.Priority = ThreadPriority.Highest;
                main.Start();
            }
            catch (Exception e) 
            {
                Console.WriteLine("The following error has occured: " + e.Message);
                Console.WriteLine("StackTrace: '{0}'", Environment.StackTrace);
                Console.ReadLine();
            }   
        }

        public static void UserMenu()
        {
            Calculator cal = new Calculator();
            bool cont = true;

            try
            {
                Console.WriteLine("Enter 2 numbers: ");
                Console.Write("First Number: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Second Number: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                while (cont)
                {
                    Console.WriteLine("What operation would you like to do?");
                    Console.WriteLine();
                    Console.WriteLine("1) Addition");
                    Console.WriteLine("2) Subtraction");
                    Console.WriteLine("3) Multiply");
                    Console.WriteLine("4) Divide");
                    Console.WriteLine("5) Remainder");
                    Console.WriteLine("6) Power");
                    Console.WriteLine("7) Exit");
                    Console.WriteLine();

                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (choice)
                    {
                        case 1:
                            Thread add = new Thread(() => { cal.Add(x, y); });
                            add.Start();

                            if (add.IsAlive)
                            {
                                add.Abort();
                            }
                            break;
                        case 2:
                            Thread sub = new Thread(() => { cal.Subtract(x, y); });
                            sub.Start();

                            if (sub.IsAlive)
                            {
                                sub.Abort();
                            }
                            break;
                        case 3:
                            Thread mul = new Thread(() => { cal.Multiply(x, y); });
                            mul.Start();

                            if (mul.IsAlive)
                            {
                                mul.Abort();
                            }
                            break;
                        case 4:
                            Thread div = new Thread(() => { cal.Divide(x, y); });
                            div.Start();

                            if (div.IsAlive)
                            {
                                div.Abort();
                            }
                            break;
                        case 5:
                            Thread rem = new Thread(() => { cal.Remainder(x, y); });
                            rem.Start();

                            if (rem.IsAlive)
                            {
                                rem.Abort();
                            }
                            break;
                        case 6:
                            Thread pow = new Thread(() => { cal.Power(x, y); });
                            pow.Start();

                            if (pow.IsAlive)
                            {
                                pow.Abort();
                            }
                            break;
                        case 7:
                            cont = false;
                            Console.WriteLine("Goodbye!");
                            Console.WriteLine();
                            break;
                        default:
                            Console.WriteLine("Error! No such option!");
                            Console.WriteLine();
                            break;
                    }
                }
            }
            catch (MethodAccessException e)
            {
                throw e;
            }
            catch (MemberAccessException e)
            {
                throw e;
            }
            catch (InvalidCastException e)
            {
                throw e;
            }
            catch (DuplicateWaitObjectException e)
            {
                throw e;
            }
            catch (OverflowException e)
            {
                throw e;
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
