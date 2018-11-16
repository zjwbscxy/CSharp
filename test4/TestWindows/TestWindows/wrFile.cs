using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWindows
{
    public class Student
    {
        public string Name;
        public string Number;
        public int Grade;
        public Student(string name,string number, int grade)
        {
            Name = name;
            Number = number;
            Grade = grade;
        }
    }
    class writefile
    {
        public FileStream F;
        public writefile(FileStream F)
        {
            this.F = F;
        }
        public void WriteInt(int i)
        {
            byte[] intBuff = BitConverter.GetBytes(i); // 将 int 转换成字节数组      
            F.Write(intBuff, 0, 4);
        }
        public void WriteString(string str)
        {
            byte[] strArray = System.Text.Encoding.Default.GetBytes(str);
            WriteInt(strArray.Length);
            F.Write(strArray, 0, strArray.Length);
        }
        public int ReadInt()
        {
            byte[] intArray = new byte[4];
            F.Read(intArray, 0, 4);
            int iRead = BitConverter.ToInt32(intArray, 0);
            return iRead;
        }
        public string ReadString()
        {
            int len = ReadInt();
            byte[] strArray = new byte[len];
            F.Read(strArray, 0, len);
            string strRead = System.Text.Encoding.Default.GetString(strArray);
            return strRead;
        }
    }
    class wrFile
    {
        public wrFile(List<Student> students)
        {
            FileStream F = new FileStream("E:\\CSharp\\CSharp\\test4\\TestWindows\\result.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            writefile writefile = new writefile(F);
            string strWrite = "";
            //考号、学生姓名、分数
            //Student student = new Student(name,number,grade);
            //strWrite = JsonConvert.DeserializeObject(students);
            foreach (Student student in students)
            {
                //stuStrs.Add(student);
                strWrite += "name:" + student.Name + ",number:" + student.Number + ",grade:" + student.Grade + ";";
            }
            writefile.WriteString(strWrite);
            
            F.Position = 0;
            string strRead = writefile.ReadString();
            F.Close();
        }
       
    }
    class readfile
    {
        public string[] grades;
        public readfile()
        {
            FileStream F = new FileStream("E:\\CSharp\\CSharp\\test4\\TestWindows\\result.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            writefile writefile = new writefile(F);
            //考号、学生姓名、分数
            //Student student = new Student(name,number,grade);
            F.Position = 0;
            string strRead = writefile.ReadString();
            //int intRead = writefile.ReadInt();
            char[] separator = { ';' };
            grades = strRead.Split(separator);

            F.Close();
        }

    }
}
