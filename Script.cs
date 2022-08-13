using System;

public class FindMultipliersOfYears
{
    public static void Main(string[] args)
    {
       
        int zero = 0;
        DateTime startDate = new DateTime(2039, 1, 1);
        DateTime lastDate = startDate;
        for (int i = 0; i < 18629; i++) 
        {
            DateTime currentDate = lastDate.AddDays(1);
            lastDate = currentDate;
            
            if(currentDate.Month < 10)
            {
                int dateNumber = int.Parse(currentDate.Day.ToString() + zero.ToString() + currentDate.Month.ToString() + currentDate.Year.ToString());
                Console.WriteLine(dateNumber);
                returnAllFactors(dateNumber);
            }
            else
            {
                int dateNumber = int.Parse(currentDate.Day.ToString() + currentDate.Month.ToString() + currentDate.Year.ToString());
                Console.WriteLine(dateNumber);
                returnAllFactors(dateNumber);
            }
        }
    }
    
    public static void returnAllFactors(int number)
    {
            int factor;
            for (factor = 1; factor <= number; factor++)
            {
                if (number % factor == 0)
                {
                    Console.Write(factor + ",");
                }
            }
            
            Console.WriteLine(" ");
    }
}
