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
            return (obj.GetType() == this.GetType() && ((Node)obj).Value == this.Value);            
        }

        public Node GetEndNode()
        {
            if(NextNode != null)
            {
                return NextNode.GetEndNode();
            }
            return this;
        }

        public String[] GetNextNodeValues(bool skipFirst = false)
        {
            if(NextNode == null) { return new String[] { this.Value };}
            String[] nextNodes = NextNode.GetNextNodeValues();
            if (skipFirst)
            {
                return nextNodes;
            }
            var output = new String[nextNodes.Length + 1];
            output[0] = this.Value;
            Array.Copy(nextNodes, 0, output, 1, nextNodes.Length);
            return output;
        }

        public String[] GetPreviousNodeValues(bool skipFirst = false)
        {
            if (PreviousNode == null) { return new String[] { this.Value }; }
            String[] previousNodes = PreviousNode.GetPreviousNodeValues();
            if (skipFirst)
            {
                return previousNodes;
            }
            var output = new String[previousNodes.Length + 1];
            output[0] = this.Value;
            Array.Copy(previousNodes, 0, output, 1, previousNodes.Length);
            return output;
        }
    }
}
