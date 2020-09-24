using System;
using System.Collections.Generic;
using System.Text;

namespace StaticDemoProject
{
    class StaticDemoClass
    {
        public static int StaticProp { get; set; }
        public int InstanceProp { get; set; }

        public static void StaticMethod()
        {
            Console.WriteLine("Static Method!");
            Console.WriteLine(StaticProp);
            //Console.WriteLine(InstanceProp);
            //InstanceMethod();
        }

        public void InstanceMethod()
        {
            Console.WriteLine("Instance Method");
            Console.WriteLine(StaticProp);
            Console.WriteLine(InstanceProp);
            StaticMethod();
        }
    }
}
