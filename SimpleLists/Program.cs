using System;

namespace SimpleLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new SimpleLists.Lists.ArrayList();
            list.Add("wilma");
            list.Add("fred");
            list.Add("pete");
            list.Add("john");
            var b = list.Nodes();
            Console.ReadLine();
        }
    }
}