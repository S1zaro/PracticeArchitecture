using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;

namespace DataAccessLayer
{
    internal class DBContext : DbContext
    {
        public DbSet<Figure> Figures { get; set; }

        public DBContext() : base ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jarri\\source\\repos\\Model\\DataAccessLayer\\Database1.mdf;Integrated Security=True")
        { }

    }
}
