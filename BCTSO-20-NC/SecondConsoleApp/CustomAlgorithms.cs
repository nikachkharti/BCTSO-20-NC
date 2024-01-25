namespace SecondConsoleApp
{
    public static class CustomAlgorithms
    {
        public static int[] Clear(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = default;
            }

            return array;
        }
        public static int GetLastElement(int[] array)
        {
            return array[array.Length - 1];
        }
        public static int[] FindAll(int[] array, int element)
        {
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                    counter++;
            }

            int[] result = new int[counter];
            int resultIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    result[resultIndex] = element;
                    resultIndex++;
                }
            }

            return result;
        }
        public static List<int> FindAll(List<int> intList, int element)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] == element)
                {
                    result.Add(element);
                }
            }

            return result;
        }
        public static int FindIndex(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    return i;
                }
            }

            return -1;
        }
        public static int FindLastIndex(int[] array, int element)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] == element)
                {
                    return i;
                }
            }

            return -1;
        }
        public static int FirstOrDefault(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    return element;
                }
            }

            return default;
        }
        public static int LastOrDefault(int[] array, int element)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] == element)
                {
                    return element;
                }
            }

            return default;
        }
        public static int[] Reverse(int[] array)
        {
            Stack<int> stackResult = new();

            for (int i = 0; i < array.Length; i++)
            {
                stackResult.Push(array[i]);
            }

            return stackResult.ToArray();
        }

        //public static int[] ReverseForArray(int[] array)
        //{
        //    List<int> result = new();

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
        public static int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int t = array[j];
                        array[j] = array[i];
                        array[i] = t;
                    }
                }
            }

            return array;
        }
        public static bool Any(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool All(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != element)
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
    }
}
