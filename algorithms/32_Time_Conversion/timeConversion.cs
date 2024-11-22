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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        String[] timeArray = s.Split(':');
        int hour = int.Parse(timeArray[0]);
        string minute = timeArray[1];
        string second = timeArray[2];
        string newSecond = second.Substring(0, second.Length - 2);

        if(second.Contains("AM") && hour == 12)
        {
            hour = 0;
        }
        
        if(second.Contains("PM") && hour != 12){
            hour += 12;
        }
        return ($"{hour:00}:{minute}:{newSecond}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
