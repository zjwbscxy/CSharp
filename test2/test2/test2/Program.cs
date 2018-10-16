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
            string fileName = @"E:\test2\科研细则.docx";//将地址存储到字符串fileName
            using (WordprocessingDocument myDocument = WordprocessingDocument.Open(fileName, true))
            {
                Body word = myDocument.MainDocumentPart.Document.Body;//将科研细则内的正文存储到word
                foreach (var duan in word.Elements<Paragraph>())
                {
                    Console.WriteLine(duan.InnerText);//将word中存储的正文逐行打印
                }
            }
            Console.WriteLine("All done. Press a key.");//程序已经跑完，按任意按键退出
            Console.ReadKey();
        }
    }
}
