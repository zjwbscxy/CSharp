using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    class Match
    {
        public int jifeng(int idx, char[] str, char[] subStr, ref bool found)
        {
            int idx_org = idx;
            int i;
            while (idx < str.Length)
            {
                while (idx < str.Length)//找到第一个相同字符的位置
                {
                    if (str[idx++] == subStr[0])
                        break;
                }

                if (idx == str.Length || subStr.Length - 1 > str.Length - idx)//如果第一个字符都不匹配，或者如果str原本长度减去idx中剩余的字符不足，返回false
                    break;


                for (i = 1; i < subStr.Length; i++, idx++)//找到第一个相同的字符之后，判断是否其后的字符都相等
                {
                    if (subStr[i] != str[idx])//如果不匹配
                    {
                        idx_org++;
                        idx = idx_org;
                        break;
                    }
                }

                if (i == subStr.Length)//如果所有字符匹配
                {
                    found = true;
                    return idx;
                }
            }
            found = false;
            return str.Length;
        }
    }
}
