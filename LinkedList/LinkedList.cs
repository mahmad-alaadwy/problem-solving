//using proplems_solved.LinkedListt;

//LinkedListt<int> x = new LinkedListt<int>();

//Node<int> y = new Node<int>();
//y.Value = 5;
//Node<int> v = new Node<int>();
//v.Value = 6;

//Node<int> m = new Node<int>();
//m.Value = 9;

//Node<int> f = new Node<int>();
//f.Value = 1;

//Node<int> mid = new Node<int>();
//mid.Value = 7;


//x.InsertAt(0, y);
//x.InsertAt(1, v);
//x.Append(m);
//x.PrePend(f);
//x.InsertAt(1, mid);
//x.Traverse();
//x.RemoveAt(1);
//x.Traverse();



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
            if (Head == null && Tail == null)
            {
                Head = Tail = newNode;
                return;
            }
            newNode.Next=Head;
            Head!.Previous = newNode;
            Head=newNode;
        }

        public void Append(Node<T> newNode)
        {
            if (Head == null && Tail == null)
            {
                Head=Tail=newNode;
                return;
            }

            Tail.Next = newNode;
            newNode.Previous = Tail;
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
            if (Head == null && Tail == null)
            {
                Head = Tail = node;
                return;
            }
            if (index == 0)
            {
                node.Next = Head;
                Head = node;
                return;
            }
            int i = 0;
            Node<T> current = Head!;
            while (i!=index) 
            {
                if (current!.Next == null)
                {
                    current.Next = node;
                    node.Previous = Tail;
                    Tail = node;
                    return;
                }
                current = current.Next;
                i++;
            }

            node.Next = current;
            node.Previous = current!.Previous;
            current.Previous!.Next= node;
            current.Previous = node;
        }

        public void RemoveAt(int index)
        {
            if (Head == null && Tail == null)
            {
                throw new ArgumentException("the current linked list doesnt have nay items");
            }

            if (index == 0)
            {
                Head=Head.Next!;
                Head.Previous = null;
                return;
            }

            int i = 1;
            Node<T> current = Head.Next!;
            while (i != index)
            {
                if (current!.Next == null)
                {
                    throw new ArgumentException($"the current linked list doesnt have any items with the index {index}");
                }
                current = current.Next!;
                i++;
            }
            if (Head == Tail)
            {
                Head = Tail = null;
                return;
            }
            if (current == Tail)
            {
                Tail = Tail.Previous;
                Tail.Next = null;
            }

            current.Previous!.Next = current.Next;
            current.Next!.Previous = current.Previous;
            current.Previous = null;
            current.Next = null;
        }


        public void Traverse()
        {
            Node<T> current = Head;
            while(current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next!;
            }
        }
    }
}
