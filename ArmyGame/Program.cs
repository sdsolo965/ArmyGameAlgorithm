using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Passed all 22 test cases on HackerRank.
     */
    static int gameWithCells(int n, int m)
    {
        int drop = 0;
        /*If row or columns are equal to one then divide the opposite by
        * 2 and that will provide you with your total drops needed, if number is
        * odd, round up and divide by two.
        */
        if (m == 1 || n == 1)
        {
            if (m == 1) { drop += (n % 2 == 0) ? n / 2 : (n + 1) / 2; }
            else { drop += (m % 2 == 0) ? m / 2 : (m + 1) / 2; }
        }
        //If m or n doesn't equal one but sum is less than 6, only two possibilities.
        else if (m + n < 6)
        {
            drop = (m + n == 5) ? 2 : 1;
        }
        //All other cases fall within here.
        else
        {
            drop += (m % 2 == 0) ? m / 2 : (m + 1) / 2;
            drop *= (n % 2 == 0) ? n / 2 : (n + 1) / 2;
        }
        return drop;

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int result = gameWithCells(n, m);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

