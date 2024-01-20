namespace SecondConsoleApp
{
    public class CustomAlgorithms
    {
        public int[] Clear(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = default;
            }

            return array;
        }
        public int[] FindAll(int[] array, int element)
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
    }
}
