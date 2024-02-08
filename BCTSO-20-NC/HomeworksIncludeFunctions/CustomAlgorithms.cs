namespace Homeworks
{
    public static class CustomAlgorithms
    {
        #region EXTRA
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
        #endregion

        public static IEnumerable<T> CustomDistinct<T>(this IEnumerable<T> source, IEqualityComparer<T> equalityComparer = null)
        {
            HashSet<T> set = new(equalityComparer);

            foreach (var item in source)
            {
                set.Add(item);
            }
            return set;
        }
        public static IEnumerable<T> CustomFindAll<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }

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
        public static IList<T> CustomOrderBy<T>(this IList<T> source, Func<T, T, bool> comparer)
        {
            for (int i = 0; i < source.Count - 1; i++)
            {
                for (int j = i + 1; j < source.Count; j++)
                {
                    if (comparer(source[j], source[i]))
                    {
                        T t = source[j];
                        source[j] = source[i];
                        source[i] = t;
                    }
                }
            }

            return source;
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
        public static IEnumerable<T> CustomTake<T>(this IEnumerable<T> source, int quantity)
        {
            foreach (var item in source)
            {
                if (quantity == 0)
                    yield break;

                yield return item;
                quantity--;
            }
        }
        public static IEnumerable<TResult> CustomSelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            foreach (var item in source)
                yield return selector(item);
        }
        public static IEnumerable<T> CustomForeach<T>(this IEnumerable<T> source)
        {
            var sourceEnumerator = source.GetEnumerator();

            while (sourceEnumerator.MoveNext())
            {
                yield return sourceEnumerator.Current;
            }
        }
    }
}
