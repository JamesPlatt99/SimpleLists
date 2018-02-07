﻿using System;
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

        public void Remove(string value)
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

        public String[] GetNextNodes(String value)
        {
            Node node = FindNode(value);
            return node.GetNextNodeValues(true);
        }

        public string Find(String value)
        {
            Node curNode = _startNode;
            while (curNode != null)
            {
                if(curNode.Value == value) { return curNode.Value; }
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

        public string[] Values()
        {
            return _startNode?.GetNextNodeValues() ?? new string[] { };
        }
    }
}
