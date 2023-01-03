using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        [StringLength(50)]
        public string Kategoriler { get; set; }
        //public ICollection<Diziler> Dizilers { get; set; }
        //public ICollection<Filmler> Filmlers { get; set; }
    }
}
