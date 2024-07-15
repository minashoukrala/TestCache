using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Node
    {


        public int Val;
        public Node Next;
        public Node Prev;

        public Node(int val)
        {

            this.Val = val;
            this.Prev = null;
            this.Next = null;
        }

    }

    public class LL
    {


        public Node Head;
        public Node Tail;

        public LL(Node first)
        {
            this.Head = first;
            this.Tail = first;
        }

        public void Insert(Node InsertedNode)
        {

            Node NewNode = InsertedNode;

            if (this.Head == null)
            {
                this.Head = NewNode;
                this.Tail = NewNode;
            }
           
            else
            {

                Head.Prev = NewNode;

                NewNode.Next = this.Head;

                Head = NewNode;

            }
        }


        public void DeleteNode()
        {

            this.Tail = Tail.Prev;
            Tail.Next = null;
            Console.WriteLine("DELETED");
            return;


        }

        public void Update(Node target)
        {

            //if it is head , we will do anything
            if (target == Head)
                return;

            //if it the tail DeleteNode and call Insert
            if (target == Tail)
            {
                this.Insert(target);
                this.DeleteNode();
                return;

            }


            //if it is mid
            else
            {
                Node TargetNext = target.Next;
                Node TargetPrev = target.Prev;

                TargetNext.Prev = TargetPrev;
                TargetPrev.Next = TargetNext;
                this.Insert(target);
                return;


            }

        }



    }

}
