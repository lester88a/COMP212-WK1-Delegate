using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //create delegate instance(objects)
            NumberChanger nc1 = new NumberChanger(addNum);
            NumberChanger nc2 = new NumberChanger(multNum);
            //call method through delegate
            nc1(25);
            Console.WriteLine("value of: {0}", getNum());
            nc2(2);
            Console.WriteLine("value of: {0}", getNum());
        }

        static int num = 10;
        public static int addNum(int p)
        {
            num += p;
            return num;
        }
        public static int multNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
    }
    delegate int NumberChanger(int n);
    //class TestDelegate 
    //{
    //    static int num = 10;
    //    public static int addNum(int p)
    //    {
    //        num += p;
    //        return num;
    //    }
    //    public static int multNum(int q)
    //    {
    //        num *= q;
    //        return num;
    //    }
    //    public static int getNum()
    //    {
    //        return num;
    //    }
    //}
}
