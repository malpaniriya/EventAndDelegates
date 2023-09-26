using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegates.Delegates
{
    internal class AcceptName
    {
        
    internal class Deligate1
    {
   
        
            static void Main(string[] args)
            {
                User u = new User();
                Mydelegate md = new Mydelegate(u.AcceptName);
                md += new Mydelegate(u.StringTolower);
                md += new Mydelegate(u.StringToupper);

                Delegate[] list = md.GetInvocationList();

                foreach (Delegate d in list)
                {
                    Console.WriteLine(d.Method);
                    string result = Convert.ToString(d.DynamicInvoke("Hello All"));
                    Console.WriteLine(result);

                }
            }
        }
        public delegate string Mydelegate(string s);
        public class User
        {

            public string AcceptName(string name)
            {
                return name;

            }
            public string StringToupper(string name)
            {
                return name.ToUpper();

            }
            public string StringTolower(string name)
            {
                return name.ToLower();

            }
        }
    }
}

