using System;
using AppVentas.Models;

namespace AppVentas.ViewModels
{
    internal class SQLiteConnection
    {
        private string dbPath;

        public SQLiteConnection(string dbPath)
        {
            this.dbPath = dbPath;
        }

        internal int Insert(Ventas ventas)
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}