using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAssignment1
{
    public class Utils
    {
        public static int[] _ArrayToBeSorted;

        public static int[] SortArray()
        {
            try
            {
                int lenArr = _ArrayToBeSorted.Length;
                if (_ArrayToBeSorted.Any())
                    for (int i = 0; i < lenArr - 1; i++)
                        for (int j = 0; j < lenArr - i - 1; j++)
                            if (_ArrayToBeSorted[j] > _ArrayToBeSorted[j + 1])
                            {
                                int temp = _ArrayToBeSorted[j];
                                _ArrayToBeSorted[j] = _ArrayToBeSorted[j + 1];
                                _ArrayToBeSorted[j + 1] = temp;
                            }
            }
            catch (Exception ex)
            {

            }
            return _ArrayToBeSorted;
        }

        /// <summary>
        /// -1 Means, value not found
        /// </summary>
        /// <param name="valueToBeSearchedInSortedArray"></param>
        /// <returns></returns>
        public static int FindValueFromSortedArray(int valueToBeSearchedInSortedArray)
        {
            int valueFromArray = 0;
            try
            {
                if (valueFromArray > _ArrayToBeSorted.Length)
                    return -1;
                else
                    return _ArrayToBeSorted[valueFromArray];
            }
            catch (Exception ex)
            {
                valueFromArray = -1;
            }
            return valueFromArray;
        }

        public static void ShowMessageForMultiples()
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine("For " + i.ToString() + " , Message=Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("For " + i.ToString() + " , Message=Buzz");
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("For " + i.ToString() + " , Message=FizzBuzz");
            }
        }
    }
}