using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class GirisYap
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string KullaniciAdi { get; set; }
        [StringLength(50)]
        public string KullaniciSifre { get; set; }
    }
}
