using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate
{
    public class Context : DbContext
    {
        public DbSet<AdminGiris> AdminGirises { get; set; }
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<Diziler> Dizilers { get; set; }
        public DbSet<Filmler> Filmlers { get; set; }
        public DbSet<GirisYap> GirisYaps { get; set; }
        public DbSet<SifreUnuttum> SifreUnutta { get; set; }
        public DbSet<UyeOl> UyeOls { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<IMDB> ıMDBs { get; set; }
    }
}
