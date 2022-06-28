using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJet.Models.Dto.Response
{
    public class ResponseProductDto
    {
        public int id_product { get; set; }
        public Byte[] principal_img { get; set; }
        public Byte[] secundary_img { get; set; }
        public string nm_product { get; set; }
        public string ds_product { get; set; }
        public int inventory { get; set; }
        public bool status { get; set; }
        public double price { get; set; }
        public double promocional_price { get; set; }
    }
}
