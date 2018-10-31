using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    class ReadWord
    {
        public string[] yuanti()//原题
        {
            string fileName = @"E:\CSharp\CSharp\test3\国考_原题.docx";
            using (WordprocessingDocument wordprocessingDocument =
            WordprocessingDocument.Open(fileName, false))
            {
                DocumentFormat.OpenXml.Wordprocessing.Body neirong = wordprocessingDocument.MainDocumentPart.Document.Body;//创建一个Body类
                List<string> yt = new List<string>();
                foreach (var g in neirong.Elements())
                {
                    yt.Add(g.InnerText);
                }
                char[] chArr = new char[yt.Count];//新建字符数组
                string[] str = yt.ToArray();//list变成字符串数组               
                Change CH = new Change();          
                chArr = CH.changeCh(str,yt.Count);//调用函数转化字符数组  
                string[] s = new string[chArr.Length];//再将长度转化为字符串数组               
                s = CH.changeStr(chArr);//调用函数
                return s;             
            }
        }
        public string[] biaozhundaan1()//国考标准答案1
        {
            string fileName = @"E:\CSharp\CSharp\test3\国考_标准答案1.docx";
            
            using (WordprocessingDocument wordprocessingDocument =
            WordprocessingDocument.Open(fileName, false))
            {
                DocumentFormat.OpenXml.Wordprocessing.Body neirong = wordprocessingDocument.MainDocumentPart.Document.Body;//创建一个Body类

                List<string> daan1 = new List<string>();
                foreach (var g in neirong.Elements())
                {
                    daan1.Add(g.InnerText);
                }
                char[] chArr = new char[daan1.Count];//新建字符数组                
                string[] str = daan1.ToArray();//list变成字符串数组              
                Change CH = new Change();
                chArr = CH.changeCh(str, daan1.Count);//调用函数转化字符数组               
                string[] s = new string[chArr.Length];//再将长度转化为字符串数组               
                s = CH.changeStr(chArr);//调用函数
                return s;
            }
        }
        public string[] biaozhundaan2()//国考标准答案2
        {
            string fileName = @"E:\CSharp\CSharp\test3\国考_标准答案2.docx";
            using (WordprocessingDocument wordprocessingDocument =
            WordprocessingDocument.Open(fileName, false))
            {
                DocumentFormat.OpenXml.Wordprocessing.Body neirong = wordprocessingDocument.MainDocumentPart.Document.Body;//创建一个Body类

                List<string> daan2 = new List<string>();
                foreach (var g in neirong.Elements())
                {
                    daan2.Add(g.InnerText);
                }
                char[] chArr = new char[daan2.Count];//新建字符数组
                string[] str = daan2.ToArray();//list变成字符串数组
                Change CH = new Change();
                chArr = CH.changeCh(str, daan2.Count);//调用函数转化字符数组
                string[] s = new string[chArr.Length];//再将长度转化为字符串数组                
                s = CH.changeStr(chArr);//调用函数
                return s;
            }
        }
        public string[] biaozhundaan3()//国考标准答案3
        {
            string fileName = @"E:\CSharp\CSharp\test3\国考_标准答案3.docx";
            using (WordprocessingDocument wordprocessingDocument =
            WordprocessingDocument.Open(fileName, false))
            {
                DocumentFormat.OpenXml.Wordprocessing.Body neirong = wordprocessingDocument.MainDocumentPart.Document.Body;//创建一个Body类

                List<string> daan3 = new List<string>();
                foreach (var g in neirong.Elements())
                {
                    daan3.Add(g.InnerText);
                }
                char[] chArr = new char[daan3.Count];//新建字符数组
                string[] str = daan3.ToArray();//list变成字符串数组
                Change CH = new Change();
                chArr = CH.changeCh(str, daan3.Count);//调用函数转化字符数组
                string[] s = new string[chArr.Length];//再将长度转化为字符串数组
                s = CH.changeStr(chArr);//调用函数
                return s;
            }
        }
        public string[] biaozhundaan4()//国考原题
        {
            string fileName = @"E:\zuoye\国考_原题.docx";
            using (WordprocessingDocument wordprocessingDocument =
            WordprocessingDocument.Open(fileName, false))
            {
                DocumentFormat.OpenXml.Wordprocessing.Body neirong = wordprocessingDocument.MainDocumentPart.Document.Body;//创建一个Body类

                List<string> daan4 = new List<string>();
                foreach (var g in neirong.Elements())
                {
                    daan4.Add(g.InnerText);
                }
                char[] chArr = new char[daan4.Count];//新建字符数组
                string[] str = daan4.ToArray();//list变成字符串数组
                Change CH = new Change();
                chArr = CH.changeCh(str, daan4.Count);//调用函数转化字符数组
                string[] s = new string[chArr.Length];//再将长度转化为字符串数组               
                s = CH.changeStr(chArr);//调用函数
                return s;
            }
        }
    }
}
