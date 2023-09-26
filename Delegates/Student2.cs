using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegates.Delegates
{
    internal class Student2
    {
    
        static void Main(string[] args)
        {
            try
            {
                Student stud1 = new Student();
                Message msg = new Message();
                // bind event with delegate
                stud1.Fail += new MyDelegate(msg.FailMessage);
                stud1.Pass += new MyDelegate(msg.SuccessMessage);

                stud1.AcceptPercen(65);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }

    public delegate void MyDelegate();
    public class Student
    {
        //when event raise then notification will be sent to MyDelegate
        public event MyDelegate Fail; // Fail & pass are the event names
        public event MyDelegate Pass;
        public void AcceptPercen(double per)
        {
            if (per < 30)
            {
                Fail(); // raise an event / call to event
            }
            else
            {
                Pass();
            }
        }
    }
    public class Message
    {
        public void SuccessMessage()
        {
            Console.WriteLine("You are Pass ");
        }
        public void FailMessage()
        {
            Console.WriteLine("You are Fail ");
        }
    }
}

