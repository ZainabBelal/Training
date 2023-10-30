using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT2
{
    class Question1
    {
        static void Main(string[] args)
        {
            
                int[] a = new int[100];
                int sum = 0;
                float avg;
                Console.WriteLine("Enter Size of Array:");
                int len = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter " + len + " Elements:");
                for (int i = 0; i < len; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < len; i++)
                {
                    sum += a[i];
                }
                avg = sum / len;
                Console.WriteLine("AVERAGE OF ARRAY ELEMENTS IS:" + avg);
                int min = a[0];
                int max = a[0];
                for (int i = 0; i < len; i++)
                {
                    if (a[i] > max)
                        max = a[i];
                    else if (a[i] < min)
                        min = a[i];
                }
                Console.WriteLine("MAXIMUM ELEMENT OF ARRAY IS:" + max);
                Console.WriteLine("MINIMUM ELEMENT OF ARRAY IS:" + min);

                Console.ReadLine();
            }

        }
    }

