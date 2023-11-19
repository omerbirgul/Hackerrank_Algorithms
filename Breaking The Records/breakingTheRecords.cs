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
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        int recordMost = 0;
        int recordLeast = 0;
        int highestScore = scores[0];
        int lowestScore = scores[0];
        
        for(int i = 0; i < scores.Count; i++){
            if(scores[i] > highestScore){
                 recordMost++;
                 highestScore = scores[i];
            }
        }
        
        for(int i = 0; i< scores.Count; i++){
            if(scores[i] < lowestScore){
                recordLeast++;
                lowestScore = scores[i];
            }
        }
        List<int> algorithmResult = new List<int>();
        algorithmResult.Add(recordMost);
        algorithmResult.Add(recordLeast);
        return algorithmResult;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
