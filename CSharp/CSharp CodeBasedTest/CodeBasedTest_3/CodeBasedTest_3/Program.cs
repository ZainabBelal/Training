using System;


namespace CodeBasedTest_3
{
    class Cricket
    {
        public void PointsCalculation(int no_of_matches){
            int[] score = new int[no_of_matches];
            double sum = 0;
            for(int i= 0; i<no_of_matches;i++)
            {
                Console.WriteLine($"Enter the Score for IPL match '{i+1}': ");
                
                int score1 = Convert.ToInt32(Console.ReadLine());
                score[i] = score1;
                sum += score1;

            }
            double avg = sum / no_of_matches;
            Console.WriteLine($"Sum of all scores: {sum}");
            Console.WriteLine($"Average score for the Team in All matches : {avg}");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------IPL Score and Average score Calculator------------");
            Console.WriteLine("Enter the number of matches the team has played(Enter a value>0): ");
            int noofmatches = Convert.ToInt32(Console.ReadLine());
            if (noofmatches > 0)
            {
                Cricket cric = new Cricket();
                cric.PointsCalculation(noofmatches);
            }
            else
            {
                Console.WriteLine("Invalid value entered");
            }
            Console.ReadLine();

        }
    }
}
