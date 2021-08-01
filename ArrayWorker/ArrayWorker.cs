using System;

namespace ClassLibrary
{
    public class ArrayWorker

       
    {
        public int[] Insert(int[] source, int index, int newValue)
        {
            int[] result = new int[source.Length+1];

            for (int i = 0; i < index-1; i++)
            {
                result[i] = source[i];
            }
            result[index-1] = newValue;
            for (int i = index-1; i < source.Length; i++)
            {
                result[i+1] = source[i];
            }
            
            return result;
        }

        




       /* public int[] Invert(int[] myArray)
         {
             int[] invertArray = new int[myArray.Length];

             int j = 0;
             for (int i = myArray.Length-1; i >=0 ; i--)
             {
                 invertArray[j] = myArray[i];
                 j++;
             }

             return invertArray;
            }*/

        public int[] Invert(int[] myArray)
        {
            int[] invertArray = new int[myArray.Length];

            for (int i = 0; i < myArray.Length; i++)
            {
                invertArray[i] = myArray[myArray.Length-1-i];
                
            }

            return invertArray;
        }




    }
}
