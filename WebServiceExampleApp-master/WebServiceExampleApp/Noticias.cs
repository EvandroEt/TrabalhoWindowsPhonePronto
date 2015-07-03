using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceExampleApp.Repository
{

    [Table(Name = "Noticia")]
   public class Noticias
    {

        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity", AutoSync = AutoSync.OnInsert, CanBeNull = false)]
        public int Id { get; set; }

        [Column (CanBeNull = false)]
        public String title { get; set; }

        [Column(CanBeNull = false)]
        public String link { get; set; }

        [Column(CanBeNull = false)]
        public String description { get; set; }
    }
}
