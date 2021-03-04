using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            String phrase = "";
            try
            {
                while (true)
                {
                    Console.Write("Введите фразу: ");
                    phrase = ClearPhrase(Console.ReadLine());
                    Console.WriteLine(phrase);
                    if (phrase == ReverseStr(phrase))
                    {
                        Console.WriteLine("Строка является палиндромом!!");
                    }
                    else
                    {
                        Console.WriteLine("Строка не является палиндромом!!");
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        private static string ClearPhrase(String inputPhrase)
        {
            // Список символов для удаления из фразы
            string[] symbols = { "!","@","\"",",",".","?","`"," ", "<",">","^","%","$","#","/","~","(",")","_","-","+" };
            for (int i = 0; i < symbols.Length; i++)
            {
                // Удаление символа из строки
                inputPhrase = inputPhrase.Replace(symbols[i], "");
            }
            // Возврат строки
            return inputPhrase;
        }
        // Реверсируем строку
        private static string ReverseStr(string InputStr)
        {
            string outStr = "";
            // Цикл реверсирования строки
            for (int i = InputStr.Length-1; i >= 0 ; i--)
            {
                outStr += InputStr[i];
            }
            // Возврат строки
            return outStr;
        }
    }
}
