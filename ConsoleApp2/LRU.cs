using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class LRU
    {
        public LL visitedList;
        public Dictionary<int, Node> References;
        public int cacheSize;

        public LRU(Node head, int cacheSize)
        {

            this.visitedList = new LL(head);
            this.cacheSize = cacheSize;
            this.References = new Dictionary<int, Node>();
            this.References.Add(head.Val, head);

        }

        public void visit(int val)
        {
            Node NewVisited;
            if (this.References.ContainsKey(val))
            {
                NewVisited = References[val];
                this.visitedList.Update(NewVisited);

            }
            else
            {
                NewVisited=new Node(val);
                if (this.cacheSize <= References.Count)
                {
                    this.visitedList.DeleteNode();
                }
                this.visitedList.Insert(NewVisited);
                this.References[val]= NewVisited;

            }

        }

        public void print()
        {
            Node head = this.visitedList.Head;
            Console.WriteLine("head");
            while (head != null)
            {
                Console.WriteLine(head.Val.ToString());
                head = head.Next;
            }
            Console.WriteLine("tail");
            Console.WriteLine();
            return;
        }
    }
}
