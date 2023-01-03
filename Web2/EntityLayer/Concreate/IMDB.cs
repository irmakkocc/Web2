using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class IMDB
    {
        [Key]
        public int IMDBID { get; set; }
        [StringLength(50)]
        public string IMDBAdi { get; set; }
        [StringLength(50)]
        public string IMDBYonetmen { get; set; }
        [StringLength(20)]
        public string IMDBPuan { get; set; }
    }
}
