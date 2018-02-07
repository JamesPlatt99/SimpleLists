using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLists.Lists
{
    public interface IList
    {
        void Add(string value);
        void Remove(string value);
        void Remove(Node value);
        Node Find(string value);
        Node[] Nodes();
        String[] Values();
    }
}
