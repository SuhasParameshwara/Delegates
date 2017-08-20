using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneStringRev
{
    public delegate string strMyDel(string str);
    class TestDelegate
    {
        public string Space(string str)
        {
            char[] strArray = str.ToCharArray();
            StringBuilder strBd = new StringBuilder();
            for(int i = 0; i < str.Length; i++)
            {
                strBd.Append(strArray[i]);
                if (i != str.Length - 1)
                {
                    strBd.Append(' ');
                }
            }
            return strBd.ToString();
        }
        public string Reverse(string str)
        { 
            char[] strArray = str.ToCharArray();
            StringBuilder strBd = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                strBd.Append(strArray[i]);
            }
            return strBd.ToString();
        }
    }
    class DemoDell
    {
        static void Main(string[] args)
        {
            try
            {
                TestDelegate obj = new TestDelegate();
                Console.WriteLine("Enter any string: \n");
                string str = Console.ReadLine();
                strMyDel objSpace = obj.Space;
                str = objSpace(str);
                Console.WriteLine("\nAfter inserting space between the characters the string looks like " + str + ".");
                strMyDel objReverse = obj.Reverse;
                str = objReverse(str);
                Console.WriteLine("\nAfter reversing the string the result is " + str + ".");
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
