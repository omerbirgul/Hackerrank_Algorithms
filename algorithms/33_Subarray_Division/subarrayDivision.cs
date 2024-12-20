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

    public static int birthday(List<int> s, int d, int m)
    {
        int count = 0;
        
        for(int i = 0; i <= s.Count - m; i++)
			/*
				i bize alt dizinin başlangıç noktasını temsil eder ve bu alt dizinin boyutunu
				aşmamasını kontrol eder. Alt dizinin sonuna çok yakın bir index seçilirse,
				m uzunluğunda bir alt dizin oluşturulamaz. 
			 */
        {
            int sum = 0;
            for(int j = 0; j < m; j++)
            {
                sum += s[i + j];
            }
            
            if(sum == d) count++;
        }
        
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int d = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.birthday(s, d, m);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
