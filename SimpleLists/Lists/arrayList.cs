using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLists.Lists
{
    public class ArrayList
    {
        public ArrayList()
        {
            _nodes = new Node[0];
        }

        private Node[] _nodes;
        public Node[] Nodes()
        {
            return _nodes;
        }

        public String[] Values()
        {
            Node[] values = _nodes;
            String[] output = new String[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                output[i] = values[i].ToString();
            }
            return output;
        }

        public void Add(string value)
        {
            Node[] newList = new Node[_nodes.Length + 1];
            Array.Copy(_nodes, 0, newList, 0, _nodes.Length);
            newList[newList.Length - 1] = new Node(value);
            _nodes = newList;
        }

        public void Remove(string value)
        {
            int? index = FindNodeIndex(value);
            if(index is null) { return; }
            Node[] newList = new Node[_nodes.Length - 1];
            
            if(index != 0)
            {
                Array.Copy(_nodes, 0, newList, 0, (int)index);
            }
            if(index != _nodes.Length - 1)
            {
                Array.Copy(_nodes, (int)index + 1, newList, (int)index, newList.Length - (int)index);
            }
            _nodes = newList;
        }

        public void Remove(Node value)
        {
            int? index = FindNodeIndex(value);
            if (index is null) { return; }
            Node[] newList = new Node[_nodes.Length - 1];

            if (index != 0)
            {
                Array.Copy(_nodes, 0, newList, 0, (int)index);
            }
            if (index != _nodes.Length - 1)
            {
                Array.Copy(_nodes, (int)index + 1, newList, (int)index, newList.Length - (int)index);
            }
            _nodes = newList;
        }

        public Node Find(string value)
        {
            for(int i = 0; i < _nodes.Length; i++)
            {
                if(_nodes[i].Value == value) { return _nodes[i]; }
            }
            return null;
        }

        public int? FindNodeIndex(string value)
        {
            for (int i = 0; i < _nodes.Length; i++)
            {
                if (_nodes[i].Value == value) { return i; }
            }
            return null;
        }

        public int? FindNodeIndex(Node value)
        {
            for (int i = 0; i < _nodes.Length; i++)
            {
                if (_nodes[i] == value) { return i; }
            }
            return null;
        }


    }
}
