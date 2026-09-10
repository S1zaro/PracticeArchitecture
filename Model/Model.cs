using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Figure
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Universe { get; set; }
        public string Series { get; set; }
        public string Character { get; set; }
        public decimal Price { get; set; }

        public Figure(int id, string name, string universe, string series, string character, decimal price)
        {
            Id = id;
            Name = name;
            Universe = universe;
            Series = series;
            Character = character;
            Price = price;
        }
    }
}
