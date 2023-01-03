using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class AnaSayfa
    {
        [Key]
        public int ID { get; set; }
        [StringLength(10000)]
        public string Hakkimizda { get; set; }
        [StringLength(10000)]
        public string HakkimizdaAciklama { get; set; }
        [StringLength(10000)]
        public string Film { get; set; }
        [StringLength(10000)]
        public string FilmAciklama { get; set; }
        [StringLength(10000)]
        public string FilmUrl { get; set; }
        [StringLength(10000)]
        public string Dizi { get; set; }
        [StringLength(10000)]
        public string DiziAciklama { get; set; }
        [StringLength(10000)]
        public string DiziUrl { get; set; }
    }
}
