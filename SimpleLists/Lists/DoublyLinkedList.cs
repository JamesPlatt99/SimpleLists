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
        public Node[] GetPreviousNodes(String value)
        {
            Node node = FindNode(value);
            return node.GetPreviousNodeValues(true);
        }
    }
}
