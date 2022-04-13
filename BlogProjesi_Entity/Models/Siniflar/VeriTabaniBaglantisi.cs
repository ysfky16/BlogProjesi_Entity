using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BlogProjesi_Entity.Models.Siniflar
{
    public class VeriTabaniBaglantisi : DbContext
    {
        public DbSet<Yetenekler> Yeteneklers { get; set; }  
    }
}