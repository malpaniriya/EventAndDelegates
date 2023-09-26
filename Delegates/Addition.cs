using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegates.Delegates
{
    internal class Addition
    {
        
    internal class Deligate
    {
        public delegate int Mydelegate2(int x, int y);
        internal class Delegate
        {
            static void Main(string[] args)
            {
                user u1 = new user();
                Mydelegate2 m = new Mydelegate2(u1.Addition1);
                int result = m.Invoke(10, 20);
                Console.WriteLine(result);
            }
        }
        public class user
        {

            public int Addition1(int a, int b)
            {
                return a + b;
            }
        }
    
}
}
}
