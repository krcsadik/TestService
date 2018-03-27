using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public List<string> ConvertToArray(string str)
        {
            return  str.Split(' ').ToList();

        }

        public string ConvertToUpperCase(string str)
        {
            return str.ToUpper();
        }
        
       public int LengthOfString(string str)
        {
            return str.Length;
        }

       public List<MyClass> WordLengths(string str)
        {
            List<MyClass> outputL =new List<MyClass> ();
            string[] s = str.Split(' ').ToArray();
            foreach (string word in s)
            {
                MyClass c = new MyClass();
                c.word = word;
                c.length = word.Length;
                outputL.Add (c);
            }
            return outputL;
        }

        
    }
}
