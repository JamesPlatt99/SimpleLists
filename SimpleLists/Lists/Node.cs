using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLists.Lists
{
    public class Node
    {
        public Node(String value)
        {
            Value = value;
        }

        public string Value;
        public Node PreviousNode;
        public Node NextNode;
        public int index;
        public override bool Equals(object obj)
        {
            return ((obj.GetType() == this.GetType() && ((Node)obj).Value == this.Value) || (obj.ToString() == this.Value));            
        }

        public Node GetEndNode()
        {
            if(NextNode != null)
            {
                return NextNode.GetEndNode();
            }
            return this;
        }

        public Node[] GetNextNodes(bool skipFirst = false)
        {
            if(NextNode == null) { return new Node[] { this };}
            Node[] nextNodes = NextNode.GetNextNodes();
            if (skipFirst)
            {
                return nextNodes;
            }
            var output = new Node[nextNodes.Length + 1];
            output[0] = this;
            Array.Copy(nextNodes, 0, output, 1, nextNodes.Length);
            return output;
        }

        public Node[] GetPreviousNodeValues(bool skipFirst = false)
        {
            if (PreviousNode == null) { return new Node[] { this }; }
            Node[] previousNodes = PreviousNode.GetPreviousNodeValues();
            if (skipFirst)
            {
                return previousNodes;
            }
            var output = new Node[previousNodes.Length + 1];
            output[0] = this;
            Array.Copy(previousNodes, 0, output, 1, previousNodes.Length);
            return output;
        }

        public override string ToString()
        {
            return this.Value;
        }
    }
}
