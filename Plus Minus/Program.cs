
class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
      decimal positives = 0;
      decimal neagtives = 0;
      decimal zeros = 0;
      decimal arrayLength = arr.Count;
      
      for( int i =0; i<arrayLength; i++)
      {
        if(arr[i] > 0) positives++;
        else if(arr[i] <0) neagtives ++;
        else zeros ++;
        
      }
      
      Console.WriteLine($"{positives / arrayLength:F6}");
      Console.WriteLine($"{neagtives / arrayLength:F6}");
      Console.WriteLine($"{zeros / arrayLength:F6}");
      
      

    }

}

class Program
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);

        Console.WriteLine("hello");
    }
}
