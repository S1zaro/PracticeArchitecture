using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Model
{
    public class Logic
    {
        private List<Figure> Figures = new List<Figure>();
        private string[] GroupUniverseList = new string[] { "All", "Marvel", "DC", "Anime", "Game" };
        private string[] GroupList = new string[] {"", "Серия", "Персонаж" };

        private static Random rnd = new Random();
        private decimal Balance = 1000;

        /// <summary>
        /// Метод возращающий список всех фигурок
        /// </summary>
        /// <returns>список фигурок</returns>
        public List<Figure> ReadFigures()
        {
            return Figures;
            
        }

        /// <summary>
        /// Метод возращающий баланс пользователя
        /// </summary>
        /// <returns>баланс</returns>
        public decimal ReadBalance()
        {
            return Balance;
        }

        /// <summary>
        /// Метод возвращающий список доступных вселенных
        /// </summary>
        /// <returns>список вселенных</returns>
        public string[] ReadUniverse()
        {
            return GroupUniverseList;
        }

        /// <summary>
        /// Метод возвращающий список ключей по которым можно группировать фигурки
        /// </summary>
        /// <returns>список названий ключей</returns>
        public string[] ReadGroupList()
        {
            return GroupList;
        }

        public void ChangeBalance(decimal value)
        {
            Balance += value;
        }

        /// <summary>
        /// Метод добавления новых фигурок
        /// </summary>
        /// <param name="name">Название фигурки</param>
        /// <param name="universe">Вселенная фигурки</param>
        /// <param name="series">Серия фигурки</param>
        /// <param name="character">Имя персонажа-фигурки</param>
        /// <param name="price">Цена</param>
        public void FigureAdd(string name, string universe, string series, string character)
        {
            decimal price = rnd.Next(1, (int)Balance+1);
            if (Figures.All(figure => figure.Name != name))
            {
                if (Figures.Count == 0)
                {
                    Figures.Add(new Figure(1, name, universe, series, character, price));
                    

                }
                else
                {
                    Figures.Add(new Figure(Figures.Max(i => i.Id) + 1, name, universe, series, character, price));
                    
                }
                
            }
            else { throw new ArgumentException(); }
        }


        /// <summary>
        /// Метод удаления фигурки
        /// </summary>
        /// <param name="number">Id фигурки</param>
        public void FigureRemove(int number)
        {
            Figure figureToRemove = Figures.Find(i => i.Id == number);
            if (figureToRemove != null) {
                Figures.Remove(figureToRemove);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Метод изменения фигурки
        /// </summary>
        /// <param name="Id">Id фигурки</param>
        /// <param name="newName">Новое имя фигурки</param>
        /// <param name="newUniverse">Новая вселенная фигурки</param>
        /// <param name="newSeries">Новая серия фигурки</param>
        /// <param name="newCharacter">Новое имя персонажа фигурки</param>
        /// <param name="newPrice">Новая цена фигурки</param>
        public void FigureUpdate(int Id, string newName, string newUniverse, string newSeries, string newCharacter, decimal newPrice)
        {
            Figure figureUpdate = Figures[Id-1];
            if (Figures.Any(figure => figure.Name == newName && figureUpdate.Name != newName))
            {
                throw new ArgumentException();
            }
            if (newPrice < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (newName != null)
            {
                figureUpdate.Name = newName;
            }
            if (newUniverse != null)
            {
                figureUpdate.Universe = newUniverse;
            }
            if (newSeries != null)
            {
                figureUpdate.Series = newSeries;
            }
            if (newCharacter != null)
            {
                figureUpdate.Character = newCharacter;
            }
            if (newPrice != 0)
            {
                figureUpdate.Price = newPrice;
            }
        }


        /// <summary>
        /// Метод группирующий фигурки по значению
        /// </summary>
        /// <param name="groupValue">параметр группировки</param>
        /// <returns>Словарь с группами</returns>
        public Dictionary<string,List<Figure>> GroupFigure(string groupValue)
        {
            switch (groupValue) 
            {
                case "Серия":
                    return Figures.GroupBy(i => i.Series).OrderBy(g => g.Key).ToDictionary(k => k.Key, k => k.ToList());
                case "Персонаж":
                    return Figures.GroupBy(i => i.Character).OrderBy(g => g.Key).ToDictionary(k => k.Key, k => k.ToList());
                default:
                    throw new ArgumentException();
            }
        }

        /// <summary>
        /// Метод рассчитывающий стоимость коллекции фигурок
        /// </summary>
        /// <returns>словарь с стоимостью фигурок по вселенным</returns>
        public Dictionary<string, decimal> SumCollectionFigure()
        {
            return Figures.GroupBy(i => i.Universe).ToDictionary(k => k.Key, k => k.Sum(s => s.Price));
        }

        public bool UpgradeFigure(int id, decimal coef)
        {
            if ((decimal)rnd.NextDouble() <= (decimal)0.85/coef) {
                FigureUpdate(Figures[id].Id, null, null, null, null, Figures[id].Price * coef);
                return true;
            }
            else
            {
                FigureRemove(id+1);
                return false;
            }
        }
    }
}
