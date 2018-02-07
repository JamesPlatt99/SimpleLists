using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLists.Lists
{
    public class SinglyLinkedList : IList
    {
        protected Node _startNode;

        public SinglyLinkedList(Node start = null)
        {
            _startNode = start;
        }

        public virtual void Add(String value)
        {
            Node node = new Node(value);
            if (_startNode != null)
            {
                _startNode.GetEndNode().NextNode = node;
            }
            else
            {
                _startNode = node;
            }
        }

        public virtual void Remove(string value)
        {
            if (value == _startNode?.Value)
            {
                _startNode = _startNode.NextNode;
                Remove(value);
                return;
            }

            Node curNode = _startNode;            
            while (curNode != null)
            {
                if (curNode.NextNode?.Value == value)
                {
                    curNode.NextNode = curNode.NextNode.NextNode;
                }
                else
                {
                    curNode = curNode.NextNode;
                }
            }
        }

        public virtual void Remove(Node value)
        {
            Remove(value.Value);
        }

        public Node[] GetNextNodes(String value)
        {
            Node node = FindNode(value);
            return node.GetNextNodes(true);
        }

        public Node Find(String value)
        {
            Node curNode = _startNode;
            while (curNode != null)
            {
                if(curNode.Value == value) { return curNode; }
                curNode = curNode.NextNode;
            }
            return null;
        }

        protected Node FindNode(String value)
        {
            Node curNode = _startNode;
            while (curNode != null)
            {
                if (curNode.Value == value) { return curNode; }
                curNode = curNode.NextNode;
            }
            return null;
        }

        public Node[] Nodes()
        {
            return _startNode?.GetNextNodes() ?? new Node[] { };
        }
        public String[] Values()
        {
            Node[] values = Nodes();
            String[] output = new String[values.Length];
            for(int i = 0; i < values.Length; i++)
            {
                output[i] = values[i].ToString();
            }
            return output;
        }
    }
}
