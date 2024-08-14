using System;

class Program
{
    static void Main(string[] args)
    {
        // Задаем исходный массив строк
        string[] initialArray = { "hello", "2", "world", ":-)", "cat", "dog", "sun", "1234" };

        // Считаем количество строк, длина которых меньше или равна 3 символам
        int count = 0;
        for (int i = 0; i < initialArray.Length; i++)
        {
            if (initialArray[i].Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив нужного размера
        string[] resultArray = new string[count];

        // Заполняем новый массив
        int index = 0;
        for (int i = 0; i < initialArray.Length; i++)
        {
            if (initialArray[i].Length <= 3)
            {
                resultArray[index] = initialArray[i];
                index++;
            }
        }

        // Выводим результат
        Console.WriteLine("Массив строк длиной <= 3 символа:");
        for (int i = 0; i < resultArray.Length; i++)
        {
            Console.WriteLine(string.Join(",", resultArray));
        }
    }
}
