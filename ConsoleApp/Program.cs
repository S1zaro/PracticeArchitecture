using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Model;

namespace ConsoleApp
{
    public class Program
    {
        public static Logic logic = new Logic();

        /// <summary>
        /// Выводит список фигурок в консоль
        /// </summary>
        /// <param name="gropText">параметр группировки фигурок</param>
        private static void ShowAllFigure(string gropText)
        {
            if (gropText == "Сброс")
            {
                foreach (var figure in logic.ReadFigures())
                {
                    Console.WriteLine($"({figure.Id}) Название: {figure.Name}, Вселенная: {figure.Universe}, Серия: {figure.Series}, Персонаж: {figure.Character}, Цена: {figure.Price}");
                }
            }
            else
            {
                Dictionary<string, List<Figure>> list = logic.GroupFigure(gropText);
                foreach (var k in list)
                {
                    Console.WriteLine($"========================{k.Key}=========================");
                    foreach (var v in k.Value)
                    {
                        Console.WriteLine($"({v.Id}) Название: {v.Name}, Вселенная: {v.Universe}, Серия: {v.Series}, Персонаж: {v.Character}, Цена: {v.Price}");
                    }
                }
            }
        }


        /// <summary>
        /// Выводит главное меню в консоль
        /// </summary>
        /// <param name="groupText">параметр группировки фигурок</param>
        private static void Menu(string groupText)
        {
            Console.Clear();
            Console.WriteLine("Приложение с коллекционными фигурками");
            Console.WriteLine("=====================================");
            Console.WriteLine($"Ваш баланс - {logic.ReadBalance()}$");
            Console.Write("Сгруппировать фигурки: ");
            if (groupText == "Серия")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.Write("[Q]по серии ");
            Console.ResetColor();
            if (groupText == "Персонаж")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.Write("[W]по персонажам ");
            Console.ResetColor();
            Console.WriteLine("[E]Сброс");
            Console.WriteLine("Ваши фигурки:");
            ShowAllFigure($"{groupText}");
            Console.WriteLine();
            Console.WriteLine("=====================================");
            Console.WriteLine("[1] Добавить фигурку");
            Console.WriteLine("[2] Изменить фигурку");
            Console.WriteLine("[3] Удалить фигурку");
            Console.WriteLine("[4] Стоимость вашей коллекции");
            Console.WriteLine("[5] Улучшить фигурку");
            Console.WriteLine("[0] Выйти");
            Console.Write("Ваш выбор: ");
        }
        

        private static void AddFigureMenu()
        {
            Console.Clear();
            Console.WriteLine("Создание новой фигурки:");
            Console.Write("Впишите название фигурки:");
            string name = Console.ReadLine();
            
            Console.WriteLine("Выберите вселенную:");
            for(int i = 1; i < logic.ReadUniverse().Length; i++)
            {
                Console.WriteLine($"[{i}] {logic.ReadUniverse()[i]}");
            }
            Console.Write("Ответ:");
            string numUniverse = Console.ReadLine();
            string universe = "";
            bool flag = true;
            while (flag)
            {
                switch (numUniverse)
                {
                    case "1":
                        universe = logic.ReadUniverse()[1];
                        flag = false;
                        break;
                    case "2":
                        universe = logic.ReadUniverse()[2];
                        flag = false;
                        break;
                    case "3":
                        universe = logic.ReadUniverse()[3];
                        flag = false;
                        break;
                    case "4":
                        universe = logic.ReadUniverse()[4];
                        flag = false;
                        break;
                    default:
                        break;
                }
                if (!flag)
                {
                    break;
                }
                Console.Write("Ответ:");
                numUniverse = Console.ReadLine();
            }
            
            Console.Write("Напишите серию фигурки: ");
            string series = Console.ReadLine();
            Console.Write("Напишите персонажа фигурки: ");
            string character = Console.ReadLine();
            bool errorFlag = false;
            while (!errorFlag)
            {
                try
                {
                    logic.FigureAdd(name, universe, series, character);
                    logic.ChangeBalance(-logic.ReadFigures().Last().Price);
                    errorFlag = true;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Данное название уже занятно");
                    Console.Write("Введите название:");
                    name = Console.ReadLine();
                }
                
            }
            return;
        }


        private static void DeleteFigureMenu()
        {
            Console.Clear();
            Console.WriteLine("Выберите Id фигурки на удаление:");
            ShowAllFigure("Сброс");
            Console.Write("Ваш выбор: ");
            string num = Console.ReadLine();
            bool flag = true;
            while (flag)
            {
                try
                {
                    logic.ChangeBalance(logic.ReadFigures()[int.Parse(num) - 1].Price);
                    logic.FigureRemove(int.Parse(num));
                    flag = false;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Фигурки с данным Id не существует");
                    Console.Write("Ваш выбор: ");
                    num = Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Фигурки с данным Id не существует");
                    Console.Write("Ваш выбор: ");
                    num = Console.ReadLine();
                }
            }
            
            return;
        }

        private static void UpdateFigureMenu()
        {
            Console.Clear();
            Console.WriteLine("Выберите фигурку для изменения");
            ShowAllFigure("Сброс");
            Console.Write("Ваш выбор: ");
            string num = Console.ReadLine();
            while (!int.TryParse(num, out int numInt) || numInt <= 0 || numInt > logic.ReadFigures().Count)
            {
                Console.WriteLine("Фигурки с данным номером не найдено");
                Console.Write("Ваш выбор: ");
                num = Console.ReadLine();
            }

            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Figure figure = logic.ReadFigures()[int.Parse(num) - 1];
                Console.WriteLine($"Ваша фигурка - Название - {figure.Name}, Вселенная - {figure.Universe}, Серия - {figure.Series}, Персонаж - {figure.Character}, Цена - {figure.Price}");
                Console.WriteLine("Что вы хотите изменить?");
                Console.WriteLine("[1]Название");
                Console.WriteLine("[2]Вселенная");
                Console.WriteLine("[3]Серия");
                Console.WriteLine("[4]Персонаж");
                Console.WriteLine("[0]Выход");
                Console.Write("Ваш выбор: ");
                string ans = Console.ReadLine();
                switch (ans)
                {
                    case "1":
                        while (true)
                        {
                            try
                            {
                                Console.Write("Введите новое название: ");
                                string newName = Console.ReadLine();
                                logic.FigureUpdate(figure.Id, newName, null, null, null, 0);
                                break;
                            }
                            catch (ArgumentException)
                            {
                                Console.WriteLine("Имя занято");
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("Выберите новую вселенную:");
                        for (int i = 1; i < logic.ReadUniverse().Length; i++)
                        {
                            Console.WriteLine($"[{i}] {logic.ReadUniverse()[i]}");
                        }
                        Console.Write("Ответ:");
                        string numNewUniverse = Console.ReadLine();
                        string newUniverse = "";
                        bool flagUni = true;
                        while (flagUni)
                        {
                            switch (numNewUniverse)
                            {
                                case "1":
                                    newUniverse = logic.ReadUniverse()[1];
                                    flagUni = false;
                                    break;
                                case "2":
                                    newUniverse = logic.ReadUniverse()[2];
                                    flagUni = false;
                                    break;
                                case "3":
                                    newUniverse = logic.ReadUniverse()[3];
                                    flagUni = false;
                                    break;
                                case "4":
                                    newUniverse = logic.ReadUniverse()[4];
                                    flagUni = false;
                                    break;
                                default:
                                    break;
                            }
                            if (!flagUni)
                            {
                                break;
                            }
                            Console.Write("Ответ:");
                            numNewUniverse = Console.ReadLine();
                        }
                        logic.FigureUpdate(figure.Id, null, newUniverse, null, null, 0);
                        break;
                    case "3":
                        Console.Write("Напишите новую серию фигурки: ");
                        string newSeries = Console.ReadLine();
                        logic.FigureUpdate(figure.Id, null, null, newSeries, null, 0);
                        break;
                    case "4":
                        Console.Write("Напишите нового персонажа фигурки: ");
                        string newCharacter = Console.ReadLine();
                        logic.FigureUpdate(figure.Id, null, null, null, newCharacter, 0);
                        break;
                    case "0":
                        flag = false;
                        break;
                }

            }
            return;
        }

        private static void AllSumCollectionMenu()
        {
            Console.Clear();
            Dictionary<string, decimal> sumList = logic.SumCollectionFigure();
            Console.WriteLine($"Общая стоимость вашей коллекции - {sumList.Sum(i => i.Value)}$");
            if (sumList.ContainsKey("Marvel"))
            {
                Console.WriteLine($"Общая стоимость Marvel-фигурок - {sumList["Marvel"].ToString()}$ ");
            }
            else
            {
                Console.WriteLine("Общая стоимость Marvel-фигурок - 0$");
            }
            if (sumList.ContainsKey("DC"))
            {
                Console.WriteLine($"Общая стоимость DC-фигурок - {sumList["DC"].ToString()}$ ");
            }
            else
            {
                Console.WriteLine("Общая стоимость DC-фигурок - 0$");
            }
            if (sumList.ContainsKey("Anime"))
            {
                Console.WriteLine($"Общая стоимость Anime-фигурок - {sumList["Anime"].ToString()}$ ");
            }
            else
            {
                Console.WriteLine("Общая стоимость Anime-фигурок - 0$");
            }
            if (sumList.ContainsKey("Game"))
            {
                Console.WriteLine($"Общая стоимость Game-фигурок - {sumList["Game"].ToString()}$ ");
            }
            else
            {
                Console.WriteLine("Общая стоимость Game-фигурок - 0$");
            }
            Console.WriteLine("[Esc]Выход");
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                return;
            }
        }
        
        private static void UpgradeFigureMenu()
        {
            Console.Clear();
            Console.WriteLine("Выберите фигурку для улучшения");
            ShowAllFigure("Сброс");
            Console.Write("Ваш выбор: ");
            string num = Console.ReadLine();
            while (!int.TryParse(num, out int numInt) || numInt <= 0 || numInt > logic.ReadFigures().Count)
            {
                Console.WriteLine("Фигурки с данным номером не найдено");
                Console.Write("Ваш выбор: ");
                num = Console.ReadLine();
            }
            Figure figure = logic.ReadFigures()[int.Parse(num)-1];
            Console.WriteLine();
            Console.Clear();
            double coef = 1.5;
            double chance = 0.85 / coef * 100;
            Console.WriteLine("[W] - увеличить");
            Console.WriteLine("[S] - уменьшить");
            Console.WriteLine("Enter - потдвердить");
            Console.WriteLine($"Множитель - {coef}x");
            Console.WriteLine($"Шанс - {(int)chance}%");
            Console.WriteLine($"Цена фигурки: {figure.Price} -> {figure.Price * (decimal)coef}");
            ConsoleKey key = Console.ReadKey(true).Key;
            while (key != ConsoleKey.Enter)
            {
                switch (key)
                {
                    case ConsoleKey.S:
                        coef -= 0.1;
                        if (coef <= 1.4)
                        {
                            coef = 2.5;
                        }
                        break;
                    case ConsoleKey.W:
                        coef += 0.1;
                        if (coef >= 2.6)
                        {
                            coef = 1.5;
                        }
                        break;
                    default:
                        break;
                }
                chance = 0.85 / coef * 100;
                Console.Clear();
                Console.WriteLine("[W] - увеличить");
                Console.WriteLine("[S] - уменьшить");
                Console.WriteLine("Enter - потдвердить");
                Console.WriteLine($"Множитель - {coef}x");
                Console.WriteLine($"Шанс - {((int)chance)}%");
                Console.WriteLine($"Цена фигурки: {figure.Price} -> {figure.Price * (decimal)coef}");
                key = Console.ReadKey(true).Key;
            }
            Console.Clear();

            bool flagUpgrade = logic.UpgradeFigure(int.Parse(num)-1, (decimal)coef);
            if (flagUpgrade)
            {
                Console.WriteLine("Улучшение прошло успешно!");
            }
            else
            {
                Console.WriteLine("Улучшение провалено(((");
            }
            Thread.Sleep(2000);
            return;
            
        }
        
        static void Main(string[] args)
        {
            bool exit = false;
            string groupValue = "Сброс";
            while (!exit)
            {
                Menu(groupValue);
                string answer = Console.ReadLine().ToLower();
                switch (answer)
                {
                    case "1":
                        AddFigureMenu();
                        break;
                    case "2":
                        if (logic.ReadFigures().Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("У вас нет фигурок");
                            Thread.Sleep(2000);
                            break;
                        }
                        else 
                        {
                            UpdateFigureMenu();
                        }
                        break;
                    case "3":
                        if (logic.ReadFigures().Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("У вас нет фигурок");
                            Thread.Sleep(2000);
                            break;
                        }
                        else
                        {
                            DeleteFigureMenu();
                        }
                        break;
                    case "4":
                        AllSumCollectionMenu();
                        break;
                    case "5":
                        if (logic.ReadFigures().Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("У вас нет фигурок");
                            Thread.Sleep(2000);
                            break;
                        }
                        else
                        {
                            UpgradeFigureMenu();
                        }
                        break;
                    case "q":
                        groupValue = "Серия";
                        break;
                    case "w":
                        groupValue = "Персонаж";
                        break;
                    case "e":
                        groupValue = "Сброс";
                        break;
                    case "0":
                        exit = true;
                        break;
                }
            }
        }
    }
}
