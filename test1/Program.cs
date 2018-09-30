using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCS
{
    class LCS
    {
        /// <summary>
        /// b[i,j]记录指示c[i,j]的值是由哪一个子问题的解达到的
        /// c[i,j]存储Xi与Yj的最长公共子序列的长度
        /// </summary>
        string[,] b;        //定义的存储字符串的b数组
        int[,] c;           //定义的存放矩阵空间的数值
        char a;

        public void LCS_LENGTH1(int[] X, int[] Y)
        {
            b = new string[X.Length, Y.Length];         //这里用于存放← ↑ ↖，后续将用于输出↖的值
            c = new int[X.Length + 1, Y.Length + 1];    //位于↖右下角元素用于回溯，从而找出公共数值
            for (int i = 0; i <= X.Length; i++)
            {
                c[i, 0] = 0;//j=0,c[i,j]=0;表示LCS的长度为0
            }
            for (int j = 0; j <= Y.Length; j++)
            {
                c[0, j] = 0;//i=0,c[i,j]=0;表示LCS的长度为0
            }
            for (int i = 0; i < X.Length; i++)
            {
                for (int j = 0; j < Y.Length; j++)
                {
                    if (X[i] == Y[j])
                    {
                        a = ' ';
                        c[i + 1, j + 1] = c[i, j] + 1;
                        b[i, j] = "↖";  //表示向左上回溯↖
                    }
                    else if (c[i, j + 1] >= c[i + 1, j])
                    {
                        a = '+';
                        c[i + 1, j + 1] = c[i, j + 1];
                        b[i, j] = "↑";  //表示向上回溯↑
                    }
                    else
                    {
                        a = '+';
                        c[i + 1, j + 1] = c[i + 1, j];
                        b[i, j] = "←";  //表示向左回溯←
                    }

                }
            }
        }

        public void LCS_LENGTH2(string[] M, string[] N)
        {
            b = new string[M.Length, N.Length];         //存放← ↑ ↖
            c = new int[M.Length + 1, N.Length + 1];    //位于↖右下角元素用于回溯，从而找出公共数值
            for (int i = 0; i <= M.Length; i++)
            {
                c[i, 0] = 0;//j=0,c[i,j]=0;表示LCS的长度为0
            }
            for (int j = 0; j <= N.Length; j++)
            {
                c[0, j] = 0;//i=0,c[i,j]=0;表示LCS的长度为0
            }
            for (int i = 0; i < M.Length; i++)
            {
                for (int j = 0; j < N.Length; j++)
                {
                    if (M[i] == N[j])
                    {
                        c[i + 1, j + 1] = c[i, j] + 1;
                        b[i, j] = "↖";  //向左上回溯
                    }
                    else if (c[i, j + 1] >= c[i + 1, j])
                    {
                        c[i + 1, j + 1] = c[i, j + 1];
                        b[i, j] = "↑";  //向上回溯
                    }
                    else
                    {
                        c[i + 1, j + 1] = c[i + 1, j];
                        b[i, j] = "←";  //向左回溯
                    }

                }
            }
        }
        public void LCSW(char a, string[,] b, int[] X, int i, int j)  //根据b的内容打印出X,Y序列最长公共子序列
        {
            if (i == 0 || j == 0)
            {
                return;
            }
            if (b[i, j] == "↖")
            {
                LCSW(a, b, X, i - 1, j - 1);
                Console.WriteLine("{0}", X[i]);
            }
            else if (b[i, j] == "↑")
            {
                LCSW(a, b, X, i - 1, j);
            }
            else
            {
                LCSW(a, b, X, i, j - 1);
            }
        }

        // public void symbol(char a)
        //  {
        //    LCS.LCS_LENGTH(X,Y);
        // }
        static void Main(string[] args)   //程序从main函数开始运行
        {
            int[] L1 = { 19, 14, 13, 27, 25, 44, 10, 7 };   //自定义的数组
            int[] L2 = { 14, 13, 44, 7, 18 };
            string[] M = { "天", "不是", "我", "下", "凡", "间", "第", "一" };  //自定义的字符串
            string[] N = { "地", "天", "中", "下", "第", "一" };
            LCS lcs = new LCS();     //实例化
            lcs.LCS_LENGTH1(L1, L2);   //运用lcs
            for (int i = 0; i < L1.Length; i++)     //将回溯左上角的元素逐个打印
            {
                for (int j = 0; j < L2.Length; j++)
                {
                    if (lcs.b[i, j] == "↖")
                    {
                        Console.WriteLine("{0}", L1[i]);
                    }
                }
            }
            lcs.LCS_LENGTH2(M, N);    //将回溯左上角的元素逐个打印
            for (int i = 0; i < M.Length; i++)
            {
                for (int j = 0; j < N.Length; j++)
                {
                    if (lcs.b[i, j] == "↖")
                    {
                        Console.WriteLine("{0}", M[i]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}