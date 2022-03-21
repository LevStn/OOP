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

            InsertOne(0);
            _array[0] = value;
            Length++;

        }


       /* public void AddValuesToIndex(int value, int index)
        {


         int newLenght = (int)(_array.Length * 1.5d + 1);
         int[] newArray = new int[newLenght];




        }*/

        public void DeleteLast()
        {
            if (Length > 0)
            {
                Length--;
            }
           
        }

        public void DeleteBegin()
        {
            int [] newArray=new int[Length];    
            for(int i = 0; i < Length-1; i++)
            {
                newArray[i] = _array[i+1];

            }

            _array = newArray;
        
            Length--;

        }


        public void DeleteByIndex(int index)
        {
            if(index<Length && index>=0)
            {
                int[] newArray = new int[Length];
                newArray = _array;

               for(int i = index; i<Length-1; i++)
                {
                    newArray[i]=_array[i+1];
                }

                _array= newArray;

                Length--;

            }

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


        public void Write()
        {
            Console.Write($"L={Length} RL{_array.Length}   ");
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{_array[i]} ");
            }
            Console.WriteLine();

        }



     

    }
}