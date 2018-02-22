using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int diagonalDifference(int[][] a)
    {
        //return (a[2][0] + a[1][1] + a[0][2]) - (a[0][0] + a[1][1] + a[2][2]);

        int A=0,B=0;
        for(int i=0,x=a.Length-1;i<a.Length;i++)
        {
          A = A + a[x][i];
          B = B + a[i][i];
          x--;
        }

        return A - B;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for (int a_i = 0; a_i < n; a_i++)
        {
            string[] a_temp = Console.ReadLine().Split(' ');
            a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
        }
        int result = diagonalDifference(a);
        Console.WriteLine(result);
    }
}
