namespace FizzBuzz;

class Result
{

    /*
     * Complete the 'fizzBuzz' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void fizzBuzz(int n)
    {
      
      for (int i = 1; i <= 100; i++)
        {
            string result = "";

            if (i % 3 == 0) 
                result += "Fizz";
            if (i % 5 == 0) 
                result += "Buzz";


            Console.WriteLine(result == "" ? i.ToString() : result);
        }

    }

}

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.fizzBuzz(n);
    }
}
