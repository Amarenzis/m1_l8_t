using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2_TenRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "TenNumberTask";
            string filePath = "TenNumberTask/Task1_TenNumber.txt";
            
            //Создаём директорию
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            //Создаём файл
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            //Очишаем файл
            using (StreamWriter clearFile = new StreamWriter(filePath, false))
            {
                clearFile.Write("");
            }
            //Формируем массив чисел, для удобства проверки - в пределах от -50 до 50. Записываем в файл            
            Random random = new Random();
            int [] arrayNumber = new int [10];
            for (int i = 0; i < 10; i++)
            {
                arrayNumber[i] = random.Next(-50,50);
                //Console.WriteLine(arrayNumber[i]);
                using (StreamWriter lineFile = new StreamWriter(filePath, true))
                {
                    lineFile.WriteLine(Convert.ToString(arrayNumber[i])); 
                } 
            }
            //Считываем значения и сразу вычисляем сумму
            int Sum = 0;            
        
            using (StreamReader readedLine = new StreamReader(filePath))
            {
                //Peek - метод, позволяющий посмотреть следующий символ. Если символа нет - возвращает -1
                while (readedLine.Peek() >= 0)
                {
                    Sum += Convert.ToInt32(readedLine.ReadLine());
                }
            }
            Console.WriteLine("Сумма 10 рандомных чисел равна {0}", Sum);     

            Console.ReadKey();
        }
    }
}
