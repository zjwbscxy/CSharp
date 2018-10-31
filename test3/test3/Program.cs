using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadWord rw = new ReadWord();           
            bool a = true;
            while (a)
            {

                Console.WriteLine(" 1: 将国考_标准答案1.docx与国考_原题.docx比较得到题目与分数 ");
                Console.WriteLine(" 2: 将国考_标准答案2.docx与国考_原题.docx比较得到题目与分数 ");
                Console.WriteLine(" 3: 将国考_标准答案3.docx与国考_原题.docx比较得到题目与分数 ");
                Console.WriteLine(" 4: 将国考_原题.docx与国考_原题.docx比较得到题目与分数      ");
                Console.WriteLine("----------请通过输入相应数字1-2-3-4得到题目与分数-----------");
                Console.WriteLine("input:");
                string s1 = Console.ReadLine();
                if (s1.Equals("1"))
                {
                    LCS<string> strLCS = new LCS<string>(rw.yuanti(), rw.biaozhundaan1());
                    strLCS.Demo();
                }
                else if (s1.Equals("2"))
                {
                    LCS<string> strLCS = new LCS<string>(rw.yuanti(), rw.biaozhundaan2());
                    strLCS.Demo();
                }
                else if (s1.Equals("3"))
                {
                    LCS<string> strLCS = new LCS<string>(rw.yuanti(), rw.biaozhundaan3());
                    strLCS.Demo();
                }
                else if (s1.Equals("4"))
                {
                    LCS<string> strLCS = new LCS<string>(rw.yuanti(), rw.biaozhundaan4());
                    strLCS.Demo();
                }
                else
                {
                    Console.WriteLine("错误！It's:{0}", s1);
                    Console.WriteLine("Input Any Key Out");
                    a = false;

                }
                Console.ReadKey();
            }
            
        }
    }
}
