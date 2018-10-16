using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"E:\CSharp\CSharp\test2\科研细则.docx";//将地址存储到字符串fileName
            using (WordprocessingDocument myDocument = WordprocessingDocument.Open(fileName, true))//从WordprocessingDocument类中创建一个新的实例
            {
                Body word = myDocument.MainDocumentPart.Document.Body;//创建一个Body类
                foreach (var duan in word.Elements<Paragraph>())//遍历Body类Elements的对象
                {
                    Console.WriteLine(duan.InnerText);//将对象中存储的正文打印
                }
            }
            Console.WriteLine("All done. Press a key.");//程序已经跑完，按任意按键退出
            Console.ReadKey();
        }
    }
}
