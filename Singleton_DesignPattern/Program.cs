using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_DesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            Teacher t1=Teacher.GetTeacher();
            t1.Teach();

            Console.WriteLine("===========================");

            Teacher t2 = Teacher.GetTeacher();
            t2.Teach();
        }
    }
}
