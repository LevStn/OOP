﻿using Lists;


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
            if(index > Length )
            {
                throw new Exception("index can`t > Length");
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

            int [] newArray = new int[Length];
            newArray = _array;

            for( int i = 0; i<= Length- number; i++)
            {
                newArray[i] = _array[i+ number];


            }

           
            _array = newArray;
            Length= Length-number;
            

        }


        public void DeleteByIndexNElemets(int index, int number)
        {
            if(number<0 || number>Length || index<0 || index>Length)
            {
                throw new Exception("nubmer and index can`t <0 and > Length");
            } 

            int [] newArray = new int [Length];
            newArray = _array;

            for(int i=index; i<=Length-number; i++)
            {
                newArray[i] = _array[i + number];
            }

            _array = newArray;
            Length = Length - number;
        }


        public int GetValueIndex (int index)
        {
            int[] newArray = new int[Length];
            newArray = _array;
            newArray[index] = newArray[index];

            return newArray[index];

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


        public void ChangesByIndex(int index, int value)
        {
            if(index<0 || index>=Length)
            {
                throw new Exception("index can`t < 0 and > Length ");
            }

            _array[index] = value;
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

        public int FindeMaxElement()
        {
            int maxValue = _array.Length;
            for (int i=0; i < Length; i++)
            {
                if( _array[i] > maxValue)
                {
                    maxValue = _array[i];
                }
                   
            }    
            return maxValue;
        }


        public int FindeMinElevent()
        {
            int minValue = _array.Length;
            for (int i=0; i< Length; i++)
            {
                if (_array[i] < minValue)
                {
                    minValue = _array[i];
                }

            }

            return minValue;
        }
            

        public int FindeIndexMaxElement()
        {
           int indexMax = FindeMaxElement();
           
           for(int i=0; i< Length; i++)

               if(_array[i]==indexMax)
                {
                    indexMax = i;
                    
                }    

            return indexMax;

        }

        public int FindeIndexMinElement()
        {
            int indexMin=FindeMinElevent();

            for( int i=0; i< Length; i++)
                if( _array[i]==indexMin)
                {
                    indexMin = i;
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

        
        public void GetDecendingSort()
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
        private void InsertOne(int index)
        {

            int newLenght = _array.Length  + 1;
            int[] newArray = new int[newLenght];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i+1] = _array[i];
            }
            _array = newArray;

        }

        private void DownSize()
        {
            int newLength=_array.Length;
            int[] newArray = new int[newLength];

            for ( int i = 0; i < _array.Length; i++)
            {
                newArray[i]= _array[i];
            }

            _array= newArray;
        }




     

    }
}