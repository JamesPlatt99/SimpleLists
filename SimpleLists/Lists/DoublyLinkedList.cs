using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLists.Lists
{
    public class DoublyLinkedList : SinglyLinkedList
    {
        public override void Add(string value)
        {
            Node node = new Node(value);
            if (_startNode != null)
            {
                node.PreviousNode = _startNode.GetEndNode();
                _startNode.GetEndNode().NextNode = node;
            }
            else
            {
                _startNode = node;
            }
        }

        public override void Remove(string value)
        {
            Node node = Find(value);
            Remove(node);
        }

        public override void Remove(Node value)
        {
            if(value.Equals(_startNode))
            {
                _startNode = _startNode.NextNode;
            }
            if (value.PreviousNode != null)
            {
                value.PreviousNode.NextNode = value.NextNode;
            }
            if (value.NextNode != null)
            {
                value.NextNode.PreviousNode = value.PreviousNode;
            }
        }

        public Node[] GetPreviousNodes(String value)
        {
            Node node = Find(value);
            return node.GetPreviousNodeValues(true);
        }
    }
}
