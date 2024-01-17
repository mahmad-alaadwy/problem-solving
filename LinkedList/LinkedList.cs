using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace proplems_solved.LinkedListt
{
    public class LinkedListt<T>where T: IComparable
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public void PrePend(Node<T> newNode)
        { 
            newNode.Next=Head;
            Head=newNode;
        }
        public void Append(Node<T> newNode)
        {
            newNode.Previous = Tail;
            Tail.Next = newNode;
            Tail=newNode;
        }

        public int LookUp(T value)
        {
            Node<T> current = Head;
            int index = 0;
            while (Tail!=null)
            {
                if (current.Value.Equals(value))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }
        public void InsertAt(int index,Node<T> node)
        {
            if (index == 0)
            {
                node.Next = Head;
                Head = node;
                return;
            }
            int i = 0;
            Node<T> current = Head;
            while (i!=index) 
            {
                if (current.Next == null)
                {
                    Tail= current;
                    current.Next = node;
                    node.Previous = Tail;
                    Tail = node;
                    return;
                }
                current = current.Next;
                i++;
            }

            node.Next = current;
            node.Previous = current.Previous;
            current.Previous.Next= node;
            current.Next.Previous= node;
        }

        public void RemoveAt(int index)
        {
            if (index == 0)
            {
                Head=Head.Next;
                Head.Previous = null;
                return;
            }
            int i = 1;
            Node<T> current = Head.Next;
            Node<T> previous ;
            while (i != index)
            {
                current = current.Next;
                i++;
            }
            previous=current.Previous;
            previous.Next = current.Next;
            current.Previous = null;
            current.Next = null;
        }
        public void Traverse()
        {
            Node<T> current = Head;
            while(current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
}
