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

        public LinkedList(int[] values)
        {
            if (values.Length == 0)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                _root = new Node(values[0]);
                _tail = _root;

                for (int i = 1; i < values.Length; i++)
                {
                    AddToEnd(values[i]);
                }
            }
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
           
        }



        public void AddToBegine(int value)
        {

            Node crnt= new Node(value);
            crnt.Next = _root;
            _root=crnt; 
   
        }



        public void AddToIndex(int value, int index)
        {
            if(index > Length || index < 0)
            {
                throw new IndexOutOfRangeException("index > Length ||  index < 0");
            }

            if( index > 0)
            {

                Node tmp = _root;

                for (int i = 0; i < index - 1; i++)
                {

                    tmp = tmp.Next;

                }
                Node crnt = new Node(value);
                crnt.Next = tmp.Next;
                tmp.Next = crnt;
            }

            else
            {
                AddToBegine(value);
            }

        }


        public void DelleteToEnd()
        {

            Node crnt = _root;
            for(int i=1; i<Length-1; i++)
            {
                crnt = crnt.Next;
            }

            crnt.Next = null;
            Length--;

            
            

        }


        public void DellToBegine()
        {

            Node crnt = _root;

            crnt=crnt.Next;
            _root = crnt;

        }


        public override string ToString()
        {
            string s = "";
            Node crnt = _root;

            while (crnt != null)
            {
                s += $"{ crnt.Value}";
                crnt = crnt.Next;
            }

            return s;
        }


        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is LinkedList))
            {
                return false;
            }

            LinkedList list = (LinkedList)obj;

            if (list.Length != this.Length)
            {
                return false;
            }

            Node thisCrnt = this._root;
            Node listCrnt = list._root;

            while (thisCrnt != null)
            {
                if (thisCrnt.Value != listCrnt.Value)
                {
                    return false;
                }

                thisCrnt = thisCrnt.Next;
                listCrnt = listCrnt.Next;
            }

            return true;
        }




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
