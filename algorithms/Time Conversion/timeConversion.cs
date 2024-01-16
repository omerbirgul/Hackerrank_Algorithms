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
        string[] saatArray = s.Split(':');
        int saat = int.Parse(saatArray[0]);
        string dakika = saatArray[1];
        string saniye = saatArray[2];
        string yeniSaniye = saniye.Substring(0,saniye.Length - 2);
        
        if(saniye.Contains("PM")){
            if(saat != 12){
                saat += 12;
            }
        }else{
            if(saat == 12){
                saat = 0;
            }
        }
        string yeniSaat = saat.ToString("00");
        return ($"{yeniSaat}:{dakika}:{yeniSaniye}");
        
        

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
