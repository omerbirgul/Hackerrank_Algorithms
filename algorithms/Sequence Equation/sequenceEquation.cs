using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'permutationEquation' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY p as parameter.
     */

    public static List<int> permutationEquation(List<int> p)
    {
        /*
        p = [5,2,1,3,4]
             1 2 3 4 5
             
        1in index degeri 3 ==> 3un index degeri 4
        2nin index degeri 2 ==> 2nin index degeri 2
        3un index degeri 4 ==> 4un index degeri 5
        4un index degeri 5 ==> 5in index degeri 1
        5in index degeri 1 ==> 1in index degeri 3
        */
        List<int> result = new List<int>();
        int n = p.Count;
        for(int i = 1; i<=n; i++)
        {
            result.Add(p.IndexOf(p.IndexOf(i) +1) +1);
        }
        return result;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> p = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pTemp => Convert.ToInt32(pTemp)).ToList();

        List<int> result = Result.permutationEquation(p);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
