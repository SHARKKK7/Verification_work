internal class Program
{
    private static void Main(string[] args)
    {
        string[] inputArrayString = {"hello", "day", "Tuersday",
         "dah", "Til", "Frih", "Sday", "xih"};

        // Метод подсчета длины элементов <=3 в массиве 
        string[] UpdateStringArray(string[] inputStringArray)
        {
            // Переменная для динамического изменения размера массива
            int index = 0;
            // Буферная переменная
            int j = 0;
            // Динамический массив в котором буду хранится элементы длиной <=3
            string[] newStringArray = new string[1] { string.Empty };

            for (int i = 0; i < inputStringArray.Length; i++)
            {
                // Проверка условия длины элементов
                if (inputStringArray[i].Length <= 3)
                {
                    Console.WriteLine("Элемент массива {0} [{1}] содержит 3 или меньше символов", i, inputStringArray[i]);
                    // Здесь index определяет размерность массива
                    index++;
                    Array.Resize(ref newStringArray, index);
                    // Запись элементов в новый массив
                    while (j < index)
                    {
                        newStringArray[j] = inputStringArray[i];
                        j++;
                    }
                }
            }

            return newStringArray;
        }

        // Метод выводит массив строк длина которых меньше, либо равна 3 символам
        void printStringArray(string[] inputArray)
        {
            int i = 0;
            Console.Write("[");
            while (i < inputArray.Length - 1)
            {
                Console.Write(inputArray[i] + ", ");
                i++;
            }
            Console.Write(inputArray[i] + "]");
        }

        Console.Clear();
        //----------------------------------------------------
        string[] resultStringArray = UpdateStringArray(inputArrayString);
        
        Console.WriteLine();
        printStringArray(resultStringArray);
        //----------------------------------------------------
    }
}