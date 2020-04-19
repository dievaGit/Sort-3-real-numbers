using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            int a = 0, b = 0, c = 0;
            int[] x = new int[3];

            //Requesting data from the user
            Console.Write(" Enter the first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter the second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter the second number: ");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a > b) && (a > c))
            {
                x[0] = a;
                if (b > c)
                {
                    x[1] = b;
                    x[2] = c;
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(" The biggest is: {0}", x[i]);
                    }
                }
                else
                {
                    x[1] = c;
                    x[2] = b;
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(" The biggest is: {0}", x[i]);
                    }
                }
            }
            else
            {
                if ((b > a) && (b > c))
                {
                    x[0] = b;
                    if (a > c)
                    {
                        x[1] = a;
                        x[2] = c;
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write(" The biggest is: {0}", x[i]);
                        }
                    }
                    else
                    {
                        x[1] = c;
                        x[2] = a;
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write(" The biggest is: {0}", x[i]);
                        }
                    }
                }
                else
                {
                    if ((c > a) && (c > b))
                    {
                        x[0] = c;
                        if (b > a)
                        {
                            x[1] = b;
                            x[2] = a;
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write(" The biggest is: {0}", x[i]);
                            }
                        }
                        else
                        {
                            x[1] = a;
                            x[2] = b;
                            for (int i = 0; i < 3; i++)
                            {
                                Console.Write(" The biggest is: {0}", x[i]);
                            }
                        }
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
