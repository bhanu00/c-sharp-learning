using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPractice
{
    /// <summary>
    /// singly linked list node
    /// </summary>
    class Node<T>
    {
        public T data;
        public Node<T> Next;

        public Node(T value)
        {
            data = value;
            Next = null;
        }
    }


    class SinglyLinkedList<T>
    {
        public Node<T> Head;

        public SinglyLinkedList()
        {
            Head = null;
        }

        // add from front
        public void InsertFront(T item)
        {
            Node<T> node = new Node<T>(item);
            node.Next = Head;

            // make node as Head
            Head = node;
        }

        // add from end
        public void InserLast(T item)
        {
            Node<T> node = new Node<T>(item);
            

        }

        // add after


        // remove from front
    }
}
