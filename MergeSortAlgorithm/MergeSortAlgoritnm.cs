using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortAlgorithm
{
    internal class MergeSortAlgoritnm
    {
        private int[] _array;
        private int[] _array2;
        private int _firstIndex;
        private int _secondIndex;
        private int _thirdIndex;
        private int _center;

        public MergeSortAlgoritnm(int [] array, int[] array2)
        {
            _array = array;
            _array2 = array2;
           

        }
        public void Merge(int Left, int Right)
        {
            _firstIndex = Left;
            _center = (Left + Right) / 2;
            _secondIndex = _center + 1;
            _thirdIndex = Left;
            while(_firstIndex <= _center && _secondIndex <= Right)
            {
                if(_array[_firstIndex] < _array[_secondIndex])
                {
                    _array2[_thirdIndex++] = _array[_firstIndex++];
                }
                else
                {
                    _array2[_thirdIndex++] = _array[_secondIndex++];
                }
            }
            while (_firstIndex <= _center)
            {
                _array2[_thirdIndex++] = _array[_firstIndex++];
            }

            while(_secondIndex <= Right)
            {
                _array2[_thirdIndex++] = _array[_secondIndex++];
            }

            for(int i =Left;  i<=Right; i++)
            {
                _array[i] = _array2[i];
            }
        }

        public void MergeSort(int Left , int Right)
        {
            if(Left < Right)
            {
                if(Left+1 == Right)
                {
                    if (_array[Left] > _array[Right])
                    {
                        Swap(ref _array[Left], ref _array[Right]);
                    }
                     
                }
                else
                {
                    int center = (Left + Right) / 2;
                    MergeSort(Left, center);
                    MergeSort(center + 1, Right);
                    Merge(Left, Right);
                }
            }
        }
        public int[] FullArray(int[] array)
        {
            Random rand = new();
            for(int i =0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 11);
            }
            return array;
        } 

        public void Show()
        {
            for(int i = 0; i < _array.Length; i++)
            {
                Console.Write(_array[i] + " ");
            }
            


        }

        public void Swap(ref int left, ref int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }
    }
}
