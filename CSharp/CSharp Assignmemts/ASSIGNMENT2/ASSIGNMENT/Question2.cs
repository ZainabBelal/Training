using System;


namespace ASSIGNMENT2
{
    class Question2
    {
        public static void Main() { 
            int[] marks = new int[10]; int sum = 0, temp = 0;
            Console.WriteLine("Enter marks in 10 Subjects");
            for (int i = 0; i< 10; i++)
             {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i< 10; i++)
            {
                sum += marks[i];
            }
            Console.WriteLine("Total Sum of Marks is:" + sum);
            int min = marks[0];
            int max = marks[0];
            for (int i = 0; i < 10; i++)
            {
                if (marks[i] > max)
                    max = marks[i];
                else if (marks[i] < min)
                        min = marks[i];
             }
            Console.WriteLine("Maximum marks is:" + max);
            Console.WriteLine("Minimum marks is:" + min);
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (marks[i] > marks[j])
                    {
                        temp = marks[i];
                        marks[i] = marks[j];
                        marks[j] = temp;
                    }
                }
            }
            Console.Write("The marks in ascending order are: ");
            for (int i = 0; i < 10; i++)
             {
                Console.Write(marks[i] + " ");
             }
             for (int i = 0; i < 10; i++)
              {
                    for (int j = i + 1; j < 10; j++)
                    {
                        if (marks[i] < marks[j])
                        {
                            temp = marks[i];
                            marks[i] = marks[j];
                            marks[j] = temp;
                        }
                    }
                }
             Console.Write("\nThe marks in descending order are: ");
             for (int i = 0; i < 10; i++)
             {
                    Console.Write(marks[i] + " ");

             }
                Console.ReadLine();
         }
    }
}
