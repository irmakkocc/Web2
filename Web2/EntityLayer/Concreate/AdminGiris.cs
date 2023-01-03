using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class AdminGiris
    {
        [Key]
        public int _Id { get; set; }
        [StringLength(50)]
        public string Sifre { get; set; }
    }
}
