using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_DesignPattern
{
    public class Teacher
    {
        private static Teacher t1=new Teacher();
        private Teacher()
        {

        }
        public static Teacher GetTeacher()
        {
            return t1;
        }

        public void Teach()
        {
            Console.WriteLine("Teacher is teaching.....");
        }
    }
}
