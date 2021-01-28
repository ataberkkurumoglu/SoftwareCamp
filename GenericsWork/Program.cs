using System;

namespace GenericsWork
{
    class Program
    {
        static void Main(string[] args)
        {
            NList<string> eArr = new NList<string>();
            eArr.Add("aa   ");
            Console.WriteLine(eArr.Length);
            eArr.Add("bb");
            Console.WriteLine(eArr.Length);
        }
    }
}
