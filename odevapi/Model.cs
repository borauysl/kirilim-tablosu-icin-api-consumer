using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevapi
{
    public class MyDataModel
    {
        [Key]
        public string HesapKodu { get; set; }

        public decimal ToplamBorc { get; set; }
    }
}
