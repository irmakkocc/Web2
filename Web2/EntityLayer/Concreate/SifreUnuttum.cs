using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class SifreUnuttum
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Mail { get; set; }
        [StringLength(50)]
        public string KAdi { get; set; }
        [StringLength(50)]
        public string YeniSifre { get; set; }
    }
}
