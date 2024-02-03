namespace Homeworks
{
    public class CustomAlgorithms
    {
        public static T[] SetDefaultValue<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = default;
            }

            return array;
        }
        public static T GetLastElement<T>(T[] array)
        {
            return array[array.Length - 1];
        }

        //public static T[] FindAllForArray<T>(T[] array, T element)
        //{
        //    int counter = 0;

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i].Equals(element))
        //            counter++;
        //    }

        //    T[] result = new T[counter];
        //    int resultIndex = 0;

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i].Equals(element))
        //        {
        //            result[resultIndex] = element;
        //            resultIndex++;
        //        }
        //    }

        //    return result;
        //}

        public static IEnumerable<T> FindAll<T>(IEnumerable<T> collection, Predicate<T> predicate)
        {
            List<T> result = new List<T>();

            foreach (var item in collection)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
        public static int FindIndex<T>(IEnumerable<T> array, Predicate<T> predicate)
        {
            int indexCount = 0;
            foreach (var item in array)
            {
                if (predicate(item))
                {
                    return indexCount;
                }
                indexCount++;
            }

            return -1;
        }

        public static int FindLastIndex<T>(T[] array, Func<T, bool> predicate)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (predicate(array[i]))
                {
                    return i;
                }
            }

            return -1;
        }
        public static T FirstOrDefault<T>(T[] array, Func<T, bool> predicate)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (predicate(array[i]))
                {
                    return array[i];
                }
            }

            return default;
        }
        public static T LastOrDefault<T>(T[] array, Func<T, bool> predicate)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (predicate(array[i]))
                {
                    return array[i];
                }
            }

            return default;
        }
        public static T[] Reverse<T>(T[] array)
        {
            Stack<T> stackResult = new();

            for (int i = 0; i < array.Length; i++)
            {
                stackResult.Push(array[i]);
            }

            return stackResult.ToArray();
        }


        //public static T[] ReverseForArray<T>(T[] array)
        //{
        //    List<T> result = new();

        //    //for (int i = 0; i < array.Length; i++)
        //    //{
        //    //    result[i] = array[array.Length - 1 - i];
        //    //}

        //    for (int i = array.Length - 1; i >= 0; i--)
        //    {
        //        result.Add(array[i]);
        //    }

        //    return result.ToArray();
        //}


        public static T[] Sort<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[i]) == -1)
                    {
                        T t = array[j];
                        array[j] = array[i];
                        array[i] = t;
                    }
                }
            }

            return array;
        }


        public static bool Any<T>(T[] array, Func<T, bool> predicate)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (predicate(array[i]))
                {
                    return true;
                }
            }

            return false;
        }
        public static bool All<T>(T[] array, Func<T, bool> predicate)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (!predicate(array[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public static int Sum(int[] array)
        {
            int result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }

            return result;
        }
        public static int Sum(int[] array, Predicate<int> predicate)
        {
            int result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (predicate(array[i]))
                {
                    result += array[i];
                }
            }

            return result;
        }


        public static IEnumerable<T> Take<T>(IEnumerable<T> collection, int quantity)
        {
            throw new NotImplementedException();
        }

        public static TResult[] Select<TSource, TResult>(TSource[] data, Func<TSource, TResult> selector)
        {
            TResult[] result = new TResult[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                result[i] = selector(data[i]);
            }

            return result;
        }

    }
}
