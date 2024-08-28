namespace Common_Elements
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 0 };
            int[] array2 = { 2, 3, 4, 9 };

            int[] commonElements = CommonElements(array1, array2);

            Console.WriteLine("Common Elements: " + string.Join(", ", commonElements));
        }

        public static int[] CommonElements(int[] array1, int[] array2)
        {
            int maxSize = Math.Min(array1.Length, array2.Length);
            int[] tempArray = new int[maxSize];
            int count = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        bool alreadyAdded = false;
                        for (int k = 0; k < count; k++)
                        {
                            if (tempArray[k] == array1[i])
                            {
                                alreadyAdded = true;
                                break;
                            }
                        }

                        if (!alreadyAdded)
                        {
                            tempArray[count++] = array1[i];
                        }
                    }
                }
            }

            int[] resultArray = new int[count];
            Array.Copy(tempArray, resultArray, count);

            return resultArray;
        }
    }
}
