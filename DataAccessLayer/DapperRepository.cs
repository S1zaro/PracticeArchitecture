using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    internal class DapperRepository<T> : IRepository<T> where T: IDomainObject
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jarri\\source\\repos\\Model\\DataAccessLayer\\Database1.mdf;Integrated Security=True";
        public void Create(T obj) 
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var properties = typeof(T).GetProperties().Where(i => i.Name != "Id");
                string propValues = string.Join(",", properties.Select(i => "@" + i.Name));
                string propString = string.Join(",", properties.Select(i => i.Name));
                string str = $"INSERT INTO {typeof(T).Name + "s"} ({propString}) VALUES({propValues})";
                db.Execute(str);
            }
            
        }

        public void Update(T obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var properties = typeof(T).GetProperties().Where(i => i.Name != "Id");
                string updateString = string.Join(",", properties.Select(i => i.Name + "=" + "@" + i.Name));
                string str = $"UPDATE {typeof(T).Name + "s"} SET {updateString} WHERE Id = {obj.Id}";
                db.Execute(str);
            }
        }

        public void Delete(T obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                string str = $"DELETE FROM {typeof(T).Name + "s"} WHERE Id = {obj.Id}";
                db.Execute(str);
            }
        }

        public IEnumerable<T> ReadAll()
        {
            List<T> objects;
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                objects = db.Query<T>($"SELECT * FROM {typeof(T).Name + "s"}").ToList();
            }
            return objects;
        }

        public T ReadById(int id)
        {
            T model;
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                model = db.Query<T>($"SELECT * FROM {typeof(T) + "s"} WHERE Id = {id}").FirstOrDefault();
            }
            return model;
        }
    }
}
