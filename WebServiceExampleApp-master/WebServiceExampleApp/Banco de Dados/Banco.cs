﻿using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceExampleApp.Repository;

namespace WebServiceExampleApp.Banco_de_Dados
{
    class DataBase : DataContext
    {
        public static string DBconnetionString = "Data Source = 'isostore:TrabalhosDB.sdf'";

        public DataBase()

            : base(DBconnetionString)
        {

        }

        public Table<Noticias> Noticia
        {
            get { return this.GetTable<Noticias>(); }
        }
    }
}
