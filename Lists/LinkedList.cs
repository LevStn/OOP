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



        public void AddToBegin(int value)
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
                AddToBegin(value);
            }

        }


        public void DeleteToEnd()
        {

            if(Length==1 || Length ==0)
            {
                _root = null;
            }

            else 
            {

                Node crnt = _root;
                for (int i = 1; i < Length - 1; i++)
                {
                    crnt = crnt.Next;
                }

                crnt.Next = null;
               
            }

        }


        public void DeleteToBegin()
        {
            if(Length == 0)
            {
                _root = null;
            }
            else
            {

                Node crnt = _root;

                crnt = crnt.Next;
                _root = crnt;
            }

        }


        public void DeleteByIndex(int index)
        {

            if (index > Length || index < 0)
            {
                throw new IndexOutOfRangeException("index > Length ||  index < 0");
            }

            if ( index > 0)
            {

                Node crnt = _root;

                for (int i = 0; i < index - 1; i++)
                {
                    crnt = crnt.Next;
                }


                crnt.Next = crnt.Next.Next;


            }
            
            else
            {
                DeleteToBegin();
            }

        }



        public void DeleteToEndNElements(int number)
        {

            if (number > Length)
            {
                throw new InvalidOperationException("number > Length");
            }


            if (Length ==  number)
            {
                _root = null;
            }
            else
            {
                Node crnt = _root;
                for (int i = 1; i < Length - number; i++)
                {
                    crnt = crnt.Next;
                }
                crnt.Next = null;

            }
            

        }


        public void DeleteToBeginNElements(int number)
        {


            if (number > Length)
            {
                throw new InvalidOperationException("number > Length");
            }

            if (Length == number)
            {
                _root = null;
            }    
            else
            {

                Node crnt = _root;
                
                for(int i = Length - number; i < Length ; i++)
                {

                crnt = crnt.Next;
                }
                _root = crnt;

            }

        }



        public void DeleteByIndexNElements(int number, int index)
        {

            if (number > Length)
            {
                throw new InvalidOperationException("number > Length");
            }

            else if (index < 0 || index > Length || Length - number < index )
            {
                throw new IndexOutOfRangeException("index < 0 || index >= Length || Length - number < index");
            }
                        

            
            if ( index >0)
            {
                Node crnt = _root;
               
                for (int i = 1; i < index ; i++)
                {
                    crnt = crnt.Next;
                    
                   
                }
                for ( int j = 0; j < number ; j++)
                {

                crnt.Next= crnt.Next.Next;
                }
                
            }
            else if ( index == 0)
            {

                DeleteToBeginNElements(number);
            }

           
            

        }




        public int GetValueByIndex(int index)
        {

            Node crnt = _root;
            int value = -1;


            for (int i = 0; i < Length; i++)
            {
            
                if (i == index)
                {
            
                    value = crnt.Value;
                }
            
                crnt = crnt.Next;
            }
            
            return value;
        }



        public int FindFirstIndexByValue(int value)
        {

            int index = -1;
            Node crnt = _root;

            for(int i = 0; i < Length; i++)
            {
                if(value == crnt.Value)
                {
                    index = i;

                   
                }

                crnt= crnt.Next;

            }

            return index;
        }



        public int ChangeValueByIndex(int value, int index)
        {

            if (index <0 || index >=Length)
            {
                throw new IndexOutOfRangeException("index <0 || index >=Length");
            }

            Node crnt = _root;
            int oldValue = 0;

            for(int i=0; i< Length; i++)
            {
                if(i == index)
                {
                   oldValue = crnt.Value;

                    crnt.Value = value;
                }

                crnt = crnt.Next;
            }

            return oldValue;
        }



        public void Reverse()
        {

            Node crnt = _root;
            Node previous = null;
            while ( crnt != null )
            {
                Node nextNoda = crnt.Next;
                crnt.Next = previous;
                previous = crnt;
                crnt = nextNoda;
            }

            _root = previous;

 

        }



        public int FindValueMaxElement()
        {
            if(_root == null)
            {
                throw new NullReferenceException("_root == null");
            }

            Node crnt = _root;
            int valueMax = crnt.Value;
            
            for(int i=0; i < Length; i++)
            {
                if(crnt.Value > valueMax)
                {
                    valueMax = crnt.Value;

                }

                crnt = crnt.Next;
            }

            return valueMax;
        }



        public int FindValueMinElement()
        {

            if (_root == null)
            {
                throw new NullReferenceException("_root == null");
            }

            Node crnt = _root;
            int valueMin = crnt.Value;

            for (int i = 0; i < Length; i++)
            {
                if (crnt.Value < valueMin)
                {
                    valueMin = crnt.Value;

                }

                crnt = crnt.Next;
            }

            return valueMin;
        }



        public int FindIndexMinElement()
        {

            if (_root == null)
            {
                throw new NullReferenceException("_root == null");
            }

            Node crnt = _root;
            int minElement = FindValueMinElement();
            int indexMin = crnt.Value;

            for(int i=0; i < Length; i++)
            {

                if (crnt.Value == minElement)
                {
                    indexMin = i;

                }

                crnt = crnt.Next;
            }

            return indexMin;

        }



        public int FindIndexMaxElement()
        {

            if (_root == null)
            {
                throw new NullReferenceException("_root == null");
            }

            Node crnt = _root;
            int maxElement = FindValueMaxElement();
            int indexMax = crnt.Value;

            for (int i = 0; i < Length; i++)
            {

                if (crnt.Value == maxElement)
                {
                    indexMax = i;

                }

                crnt = crnt.Next;
            }

            return indexMax;

        }



        public void SortAscending()
        {
            
            Node crnt;
            Node prev;

            for (int i = Length - 2; i >= 0; i--)
            {
                if (i == 0)
                {
                    crnt = _root;
                    if (crnt.Next != null && crnt.Value > crnt.Next.Value)
                    {
                        _root = crnt.Next;
                        crnt.Next = _root.Next;
                        _root.Next = crnt;
                    }
                    prev = _root;
                }
                else
                {
                    prev = GetNodeByIndex(i - 1);
                    crnt = prev.Next;
                }

                while (crnt.Next != null && crnt.Value > crnt.Next.Value)
                {
                    prev.Next = crnt.Next;
                    crnt.Next = prev.Next.Next;
                    prev.Next.Next = crnt;

                    prev = prev.Next;
                }
            }

            _tail = GetNodeByIndex(Length - 1);
        }




        public void SortDescending()
        {

            Node crnt;
            Node prev;

            for (int i = Length - 2; i >= 0; i--)
            {
                if (i == 0)
                {
                    crnt = _root;
                    if (crnt.Next != null && crnt.Value < crnt.Next.Value)
                    {
                        _root = crnt.Next;
                        crnt.Next = _root.Next;
                        _root.Next = crnt;
                    }
                    prev = _root;
                }
                else
                {
                    prev = GetNodeByIndex(i - 1);
                    crnt = prev.Next;
                }

                while (crnt.Next != null && crnt.Value < crnt.Next.Value)
                {
                    prev.Next = crnt.Next;
                    crnt.Next = prev.Next.Next;
                    prev.Next.Next = crnt;

                    prev = prev.Next;
                }
            }

            _tail = GetNodeByIndex(Length - 1);
        }



        public int DeleteByValueFirst(int value)
        {

            Node crnt = _root;
            int index = -1;

            for(int i=0; i<Length;i++)
            {
                if(crnt.Value == value)
                {
                    index = i;

                    DeleteByIndex(index);
                    break;
                        
                }
                crnt = crnt.Next;
            }

            return index;
           
        }


        public int DeleteByValueAll(int value)
        {

            Node crnt = _root;
            int count = 0;
  
            while(crnt!=null)
            {
                
                if(crnt.Value == value)
                {
                    
                    count++;

                    int a = GetIndexByValue(value);
                    DeleteByIndex(a);
                }

                crnt = crnt.Next;
            }

            
            return count;

        }


        public void AddListToEnd(LinkedList newList)
        {
            if (newList._root == null || _root == null)
            {
                throw new NullReferenceException("newList._root == null");
            }

            _tail = GetNodeByIndex(Length - 1);
            _tail.Next = newList._root;





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

        private int GetIndexByValue (int value)
        {

            Node crnt = _root;
            int index = -1;
            for(int i = 0 ; i < Length; i++)
            {
                if(crnt.Value == value)
                {
                    
                    index = i;
                    break;
                }
                crnt = crnt.Next;
            }
            return index;
        }

        private Node GetNodeByIndex(int index)
        {

            Node crnt = _root;
            for (int i = 1; i <= index; i++)
            {
                crnt = crnt.Next;
            }

            return crnt;

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
