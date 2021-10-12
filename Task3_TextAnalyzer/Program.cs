using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3_TextAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Исходные данные
            string filePath = "TextAnalize/TextForAnalize.txt";
            int charQuantity = 0;
            int lineQuantity = 0;
            string text = "";
            int wordQuantity = 0;

            //Считываем файл
            using (StreamReader file = new StreamReader (filePath))
            {
                //Считаем количество символов
                while (file.Peek()>=0)
                {
                    file.Read();
                    charQuantity ++;
                }                
            }

            using (StreamReader file = new StreamReader(filePath))
            {
                //Считаем количество строк
                while (file.Peek() >= 0)
                {
                    file.ReadLine();
                    lineQuantity++;
                }
            }

            using (StreamReader file = new StreamReader(filePath))
            {
                //Для расчёта слов забираем текст в переменную
                while (file.Peek() >= 0)
                {
                    text = file.ReadLine();
                    text = text.Trim();
                    string[] textArray = text.Split();
                    wordQuantity += textArray.Length;                   
                }
            }
        
            Console.WriteLine("Количество символов {0}", charQuantity);
            Console.WriteLine("Количество слов {0}", wordQuantity);
            Console.WriteLine("Количество строк {0}",lineQuantity);
            Console.ReadKey();
        }
    }
}
