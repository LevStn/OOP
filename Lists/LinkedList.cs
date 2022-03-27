using System;
using System.Threading.Tasks;

namespace Lists
{
    public class LinkedList
    {
        private Node _root;

        private Node _tail;

        public int this[int index]
        {
            get
            {
                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }

                return crnt.Value;
            }
            set
            {

            }
        }

        public int Length
        {
            get
            {

                int count = 0;
                Node crnt = _root;

                while (crnt != null)
                {

                    crnt = crnt.Next;
                    count++;
                }
                return count;
            }

            private set
            {

            }
        }


        public LinkedList()
        {
            Length = 0;
            _root = null;
            _tail = null;
        }

        public LinkedList(int value)
        {

            Length = 1;
            _root = new Node(value);
            _tail = new Node(value);
        }


        public void AddToEnd(int value)
        {

            if (_root == null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                _tail.Next = new Node(value);
                _tail = _tail.Next;
            }
            Length++;
        }



        public void AddToBegin(int value)
        {


            Node crnt= new Node(value);
            crnt.Next = _root;
            _root=crnt; 
            

            Length++;
        }



        //public void AddToIndex(int value, int index)
        //{
        //    Node crnt = _root;
             

        //    for (int i=0; i<Length; i++)
        //    {
        //        if (index == i)
        //        {
        //           crnt.Next = new Node(value);
        //        }


        //        _root = crnt;

        //    }

        //    Length++;
            
        //}



        public void WriteLinkedList()
        {
            Node node = _root;
            Console.Write($"L={Length} ");
            while (node != null)
            {
                Console.Write($" {node.Value}");
                node = node.Next;
            }
        }


    }


}
