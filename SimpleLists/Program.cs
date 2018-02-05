using System;

namespace SimpleLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new SimpleLists.Lists.SinglyLinkedList();
            list.Add("wilma");
            list.Add("fred");
            list.Add("pete");
            list.Add("john");
            var a = list.Values();
            Console.ReadLine();
        }
    }
}