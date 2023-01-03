using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Yorumlar
    {
        [Key]
        public int YorumID { get; set; }
        [StringLength(50)]
        public string KAdi { get; set; }
        [StringLength(50)]
        public string YrmBaslik { get; set; }
        [StringLength(50)]
        public string YrmPuan { get; set; }
        [StringLength(100)]
        public string Yorum { get; set; }
        public ICollection<Diziler> Dizilers { get; set; }
        public ICollection<Filmler> Filmlers { get; set; }
    }
}
