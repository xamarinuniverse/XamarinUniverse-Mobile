namespace XamarinUniverse.Mobile.Helpers
{
    using Interfaces;
    using SQLite;
    //using SQLite.Net;
    using SQLiteNetExtensions.Extensions;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using Xamarin.Forms;
    using XamarinUniverse.Mobile.Models;

    public class DataAccess : IDisposable
    {
        private readonly SQLiteConnection connection;

        public DataAccess()
        {
            //var config = DependencyService.Get<IConfig>();

            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "xUniverse.db");

            this.connection = new SQLiteConnection(databasePath);
            //this.connection.CreateTable<Note>();
            this.connection.CreateTable<Item>();

            //this.connection = new SQLiteConnection(
            //    config.Platform,
            //    Path.Combine(config.DirectoryDB, "xUniverse.db3"));

            //connection.CreateTable<Note>();
            //connection.CreateTable<Note>();
        }

        public void Insert<T>(T model)
        {
            this.connection.Insert(model);
        }

        public void Update<T>(T model)
        {
            this.connection.Update(model);
        }

        public void Delete<T>(T model)
        {
            this.connection.Delete(model);
        }

        public List<T> GetList<T>() where T : new()
        {
            return this.connection.Table<T>().ToList();
        }

       
        public T First<T>( ) where T : new()
        {
            return this.connection.Table<T>().FirstOrDefault();
        }

        public T Find<T>(int pk, bool WithChildren) where T : new()
        {
            if (WithChildren)
            {
                //  return connection.GetAllWithChildren<T>().FirstOrDefault(m => m.GetHashCode() == pk);
                return connection.Table<T>().FirstOrDefault(m => m.GetHashCode() == pk);
            }
            else
            {
                return connection.Table<T>().FirstOrDefault(m => m.GetHashCode() == pk);
            }
        }
        
 
         

        public void Dispose()
        {
            connection.Dispose();
        }
    }

}
