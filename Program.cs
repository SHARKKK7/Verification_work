internal class Program
{
    private static void Main(string[] args)
    {
        // string[] inputArrayString = {"hello", "day", "Tuersday",
        //  "dah", "Til", "Frih", "Sday", "xih"};

        // Метод заполняет массив строк, через терминал пользователем
        string[] FillStringArray()
        {
            //============ Блок объявления переменных
            string[] AS;
            int count;
            string s;
            string[] AS2;
            //=============

            Console.WriteLine("===========================================================");
            Console.WriteLine("Заполните массив различными наборами символов через Enter, \nдалее нажмите Enter для подтвеждения: ");
            Console.WriteLine("===========================================================");

            // Обнулить количество строк
            count = 0;
            // Выделить память для 0 строк
            AS = new string[count];

            do
            {
                Console.WriteLine();

                // Ввести строку
                s = Console.ReadLine() ?? "";

                // Проверка, пустая ли строка
                if (s != "")
                {
                    // если строка не пустая, то добавить строку в массив
                    count++;

                    // предварительно выделить память для нового массива
                    // в котором на 1 элемент больше
                    AS2 = new string[count];

                    // скопировать старый массив в новый
                    for (int i = 0; i < AS2.Length - 1; i++)
                        AS2[i] = AS[i];

                    // добавить последнюю введенную строку в массив AS2
                    AS2[count - 1] = s;

                    // перенаправить ссылку AS на AS2
                    AS = AS2;
                }
                // Пока не будет введена пустая строка, программа продолжит работу
            } while (s != "");

            return AS;
        }

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
        //-----------------------------------------------------------
        string[] newUserArray = FillStringArray();
        string[] resultStringArray = UpdateStringArray(newUserArray);
        //------------------------------------------------------------
        Console.WriteLine();
        printStringArray(resultStringArray);
        //-----------------------------------------------------------
    }
}