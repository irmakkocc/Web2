using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Diziler
    {
        [Key]
        public int DiziID { get; set; }
        [StringLength(10000)]
        public string DiziAd { get; set; }
        [StringLength(10000)]
        public string Yonetmen { get; set; }
        [StringLength(20)]
        public string Puan { get; set; }
        [StringLength(10000)]
        public string DiziAciklama { get; set; }
        public int KategoriID { get; set; }
        public virtual Kategori Kategori { get; set; }
        public int YorumID { get; set; }
        public virtual Yorumlar Yorumlar { get; set; }
        //public ICollection<Yorumlar> Yorumlars { get; set; }
        //public ICollection<Kategori> Kategoris { get; set; }
    }
}
