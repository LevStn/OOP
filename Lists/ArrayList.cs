using System;


namespace Lists
{
    public class ArrayList
    {
        public int Length { get; private set; }

        private int[] _array;

        public ArrayList()
        {
            _array = new int[10];
            Length = 0;

        }

        public ArrayList(int value)
        {

            _array = new int[10];
            _array[0] = value;
            Length = 1;
        }

        public ArrayList(int[] array)
        {

            if(array== null || array.Length == 0)
            {

                _array=new int[10];
                Length=0;
            }
            else
            {

                _array = array;
                Length = array.Length;
                UpSize();
            }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }



        public void AddValuesToTheEnd(int value)
        {
            if (Length >= _array.Length)
            {

                UpSize();
              
            }

            _array[Length] = value;
            Length++;
        }



        public void AddValuesToTheBegin(int value)
        {
             if (Length >= _array.Length)
             {

                UpSize();
               
             }

            int newLength = _array.Length;
            int[] newArray = new int[newLength];

            Length++;

            for (int i = 0; i < Length-1; i++)
            {
                newArray[i+1] = _array[i];
                
            }
            _array= newArray;   


            _array[0] = value;
        }



        public void AddValuesToIndex(int value, int index)
        {
            if(index > Length || index <0  )
            {
                throw new Exception("index > Length || index <0");
            }


            if (Length >= _array.Length)
            {

                UpSize();

            }

            int newLength = _array.Length;
            int[] newArray = new int[newLength];


            for (int i = 0; i < Length; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = index; i < Length; i++)
            {
                newArray[i + 1] = _array[i];
            }

            newArray[index] = value;
            _array = newArray;

            Length++;
            

        }



        public void DeleteLast()
        {
            if (Length == 0)
            {

                throw new Exception("Length == 0");
            }

            else  
            
             Length--;           
        }



        public void DeleteBegin()
        {

            if (Length == 0)
            {

                throw new Exception("Length == 0");
            }

            for (int i = 0; i < Length; i++)
            {
                _array[i] = _array[i+1];

            }

            Length--;

        }



        public int DeleteByIndex(int index)
        {

            if(index < 0 || index >= Length)
            {
                throw new Exception("index == 0 || index >= Length");
            }

            int deleteNumb = _array[index];
            
            for(int i = index; i<Length; i++)
            {
                _array[i]=_array[i+1];
            }
            
             Length--;

            return deleteNumb;
        }



        public void DeleteTHeEndNElements (int number )
        {
            if (number>Length || number <0)
            {
                throw new Exception("number>Length || number <0 ");
            }

            if (number>0 && number<=Length)
            {                            
                Length= Length-number;
            }
        }



        public void DeleteTHeBegineNElements(int number)
        {
            if (number>Length || number<0)
            {
                throw new Exception("number can`t > Length and < 0");
            }

            for( int i = 0; i<= Length- number; i++)
            {
                _array[i] = _array[i+ number];


            }

            Length= Length-number;          
        }



        public void DeleteByIndexNElemets(int index, int number)
        {
            if(number<0 || number>Length || index<0 || index>=Length)
            {
                throw new Exception("number<0 || number>Length || index<0 || index>Length");
            } 
        
            for(int i=index; i<=Length-number; i++)
            {
                _array[i] = _array[i + number];
            }
 
            Length = Length - number;
        }



        public int GetValueIndex (int index)
        {
            if (index<0 || index>=Length)
            {
                throw new Exception(" index<0 || index>=Length ");
            }

            return _array[index];

        }



        public int FindeIndexByValue(int value)
        {
            int result = -1;
            
            for(int i=0; i<Length; i++)
            {
                if(value== _array[i])
                {
                    result= i;

                break;
                }
            }

         return result;
        }



        public int ChangesByIndex(int index, int value)
        {

            if(index<0 || index>=Length)
            {
                throw new Exception("index can`t < 0 and > Length ");
            }

            int oldNumb=_array[index];

            _array[index] = value;

            return oldNumb;
        }



        public void Reverse()
        {

           for (int i = 0; i < Length / 2; i++)
           {
               int tmp = _array[i];
               _array[i] = _array[Length - (1 + i)];
               _array[Length - (1 + i)] = tmp;
           }
    
        }



        public int FindMaxElement()
        {

            if ( Length <1)
            {
                throw new Exception(" Length <1");
                
            }

            int maxValue = _array[0];

            for (int i=0; i < Length; i++)
            {
                if( _array[i] > maxValue)
                {
                    maxValue = _array[i];
                }
                   
            }    
            return maxValue;
        }



        public int FindMinElement()
        {
            if (Length < 1)
            {
                throw new Exception(" Length <1");

            }

            int minValue = _array[0];

            for (int i=0; i< Length; i++)
            {
                if (_array[i] < minValue)
                {
                    minValue = _array[i];
                }

            }

            return minValue;
        }
            


        public int FindIndexMaxElement()
        {
            if (Length < 1)
            {
                throw new Exception(" Length <1");

            }

           int maxElement = FindMaxElement();
           int indexMax = 0;

           for(int i=0; i< Length; i++)
           {

                if (_array[i] == maxElement)
                {
                    indexMax = i;

                }

            }

            return indexMax;
        }



        public int FindIndexMinElement()
        {

            if (Length < 1)
            {
                throw new Exception(" Length <1");

            }

            int minElement = FindMinElement();
            int indexMin= _array[0];

            for( int i=0; i< Length; i++)
            {

                if (_array[i] == minElement)
                {
                    indexMin = i;
                }
            }

            return indexMin;
        }
        


        public void GetSortAscending()
        {
            int tmp;
            for (int j = 0; j < Length; j++)
            {
                for (int i = 0; i < Length - 1; i++)
                {
                    if (_array[i] > _array[i + 1])
                    {
                        tmp = _array[i + 1];
                        _array[i + 1] = _array[i];
                        _array[i] = tmp;
                    }
                }
            }
        }

        

        public void GetSortDecending()
        {
            int tmp;
            for (int j = 0; j < Length; j++)
            {
                for (int i = 0; i < Length - 1; i++)
                {
                    if (_array[i] < _array[i + 1])
                    {
                        tmp = _array[i + 1];
                        _array[i + 1] = _array[i];
                        _array[i] = tmp;
                    }
                }  
            }
        }



        public int DeleteByValueFirst(int value)
        {
            int index = -1;

            for (int i = 0; i < Length; i ++)
                if(value == _array[i])
                {
                    index = i;

                    DeleteByIndex(index);
                    break;
                }

            return index;

        }



        public int DeleteByValueAll(int value)
        {
           
            int count =0;
            for (int i = 0; i < Length; i++)


                if (_array[i] == value)
                {
                    count++;
                }
                else
                {
                    _array[i- count] =_array[i];
                }
            Length -= count;

            

            return count;

        }



        public void AddListToEnd(ArrayList newList)
        {
            
            if (newList == null)
            {

                throw new NullReferenceException();
            }

            

            int [] newArray=new int [_array.Length + newList.Length];


            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
                

            for (int i = 0; i < newList.Length; i++)
            {
                newArray[i +Length] = newList[i];

                
                
            }
            
  
            _array = newArray;
            Length += newList.Length;


        }



        public void AddListToBegin(ArrayList newList)
        {

            if (newList == null)
            {

                throw new NullReferenceException();
            }



            int[] newArray = new int[_array.Length + newList.Length];


            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i+ newList.Length] = _array[i];
            }


            for (int i = 0; i < newList.Length; i++)
            {
                newArray[i] = newList[i];



            }


            _array = newArray;
            Length += newList.Length;


        }



        public void AddListToIndex(ArrayList newList, int index)
        {

            if (newList == null)
            {

                throw new NullReferenceException("(newList == null");
            }

            if (index ==0)
            {
                AddListToBegin(newList);


                return;
            }


            int[] newArray = new int[_array.Length + newList.Length];

            if (index > Length)
            {
                throw new IndexOutOfRangeException("index > Length");
            }

                

            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }


            for (int i = 0; i < newList.Length; i++)
            {
                newArray[i+index] = newList[i];



            }

            for (int i = index ; i <= _array.Length - index; i++)
            {
                newArray[i + newList.Length] = _array[i];

            }





            _array = newArray;
            Length += newList.Length;


        }







        public void Write()
        {
            Console.Write($"L={Length} RL{_array.Length}   ");
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{_array[i]} ");
            }
            Console.WriteLine();

        }


        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < Length; i++)
            {
                s += ($"{_array[i]} ");
            }

            return s;
        }
     

        public override bool Equals(object? obj)
        {

            bool isEqual = true;

            if (obj == null || !(obj is ArrayList))
            {
                isEqual = false;
            }
            else
            {

                ArrayList list = (ArrayList)obj;


                if (list.Length != this.Length)
                {
                    isEqual = false;
                }
                else
                {
                    for (int i = 0; i < this.Length; i++)
                    {
                        if (list[i] != this[i])
                        {
                            return false;
                        }
                    }

                }
            }   
                return isEqual;
        }

        private void UpSize()
        {
            int newLenght = (int)(_array.Length * 1.5d + 1);
            int[] newArray = new int[newLenght];
            for (int i = 0; i < _array.Length; i++)
            {

                newArray[i] = _array[i];

            }

            _array = newArray;

        }
       

    }
}