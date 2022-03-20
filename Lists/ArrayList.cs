namespace Lists
{
    public class ArrayList
    {
        public int Length { get; private set; }

        private int[] _array;

        public ArrayList()
        {
            _array = new int[3];
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
            Length--;
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