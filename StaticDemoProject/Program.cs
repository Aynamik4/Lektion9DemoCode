using System;

namespace StaticDemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticDemoClass.StaticProp = 10;
            StaticDemoClass.StaticMethod();

            StaticDemoClass myInstance = new StaticDemoClass();
            myInstance.InstanceProp = 20;
            myInstance.InstanceMethod();

            double sqr = Math.Sqrt(9);

            Random r = new Random(1);

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{r.Next(1, 10 + 1)} ");
            }
        }
    }
}
