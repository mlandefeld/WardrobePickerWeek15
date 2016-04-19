using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Week15Project.Models
{
    public class Week15ProjectContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Week15ProjectContext() : base("name=Week15ProjectContext")
        {
        }

        public System.Data.Entity.DbSet<Week15Project.Models.Tops> Tops { get; set; }

        public System.Data.Entity.DbSet<Week15Project.Models.Shoes> Shoes { get; set; }

        public System.Data.Entity.DbSet<Week15Project.Models.Bottoms> Bottoms { get; set; }

        public System.Data.Entity.DbSet<Week15Project.Models.Accessories> Accessories { get; set; }
    }
}
