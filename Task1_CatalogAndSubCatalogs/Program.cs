using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1_CatalogAndSubCatalogs
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/rudarani/OneDrive - Bonava/Pictures";

            //Обработка корневого каталога и подготовка подкаталогов
            DirectoryInfo mainDirectory  = new DirectoryInfo(path);
            string mainName = mainDirectory.Name;
            Console.WriteLine("Главный каталог:");
            Console.WriteLine(mainName);
            DirectoryInfo [] arraySubDirectories = mainDirectory.GetDirectories();
            Console.WriteLine("\nСодержит:");

            //информация о каталогах
            foreach (DirectoryInfo  sub in arraySubDirectories)
            {
                Console.WriteLine("\t{0}",sub.Name);
                DirectoryInfo[] arraySubSubDirectories = sub.GetDirectories();
                foreach (DirectoryInfo subsub in arraySubSubDirectories)
                {
                    Console.WriteLine("\t\t{0}", subsub.Name);
                    FileInfo[] arraySubSubFiles = subsub.GetFiles();
                    foreach (FileInfo subsubF in arraySubSubFiles)
                    {
                        Console.WriteLine("\t\t\tФайл: {0}", subsubF.Name);
                    }
                }
                FileInfo[] arraySubFiles = sub.GetFiles();
                foreach (FileInfo subF in arraySubFiles)
                {
                    Console.WriteLine("\t\tФайл: {0}", subF);
                }
            }
            FileInfo[] arrayMainFiles = mainDirectory.GetFiles();
            foreach (FileInfo mainF in arrayMainFiles)
            {
                Console.WriteLine("\tФайл: {0}",mainF.Name);
            }
            Console.ReadKey();
        }
    }
}
