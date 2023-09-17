namespace stairCase;

class Result
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
      for(var i = 0; i<n; i++){
            string str = "";

            for(var j=0; j< n-i-1;j++){
                str += " ";
            }

            for( var k = 0; k<i+1; k++){
                str += "#";
            }

            System.Console.WriteLine(str);
        }

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
