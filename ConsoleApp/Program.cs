using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Приложение с коллекционными фигурками");
                Console.WriteLine("[1] Добавить фигурку");
                Console.WriteLine("[2] Изменить фигурку");
                Console.WriteLine("[3] Удалить фигурку");
                Console.WriteLine("[4] Показать фигурки из одной вселенной");
                Console.WriteLine("[5] Сгруппировать фигурки по серии");
                Console.WriteLine("[0] Выйти");
                Console.Write("Ваш выбор: ");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "0":
                        exit = true;
                        break;
                }
            }
        }
    }
}
