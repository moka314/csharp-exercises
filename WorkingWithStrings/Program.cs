using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string mystring = "My \"so-called\" life";
            //string mystring = "What if i need a\nnew line";
            //string mystring = "Go to your c:\\ drive";
            //string mystring = @"Go to your c:\ drive";

            //string mystring = String.Format("{0}={1}","First","Second");
            //string mystring = string.Format("{0:C}", 123.45);
            //string mystring = string.Format("{0:N}", 123456789);
            //string mystring = string.Format("{0:P}", .123);

            //string mystring = "That summer we took threes across the board";
            //mystring = mystring.Substring(6);
            //mystring = mystring.ToUpper();
            //mystring = mystring.Replace(" ", "--");
            //mystring = mystring.Remove(6, 14);
            StringBuilder mystring = new StringBuilder();
            for (int i=0; i<100; i++)
            {
                mystring.Append("--");
                mystring.Append(i);
            }


            Console.WriteLine(mystring);
            Console.ReadLine();
        }
    }
}
