using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJet.Models.Entities
{
    [Table(name:"tb_product")]
    public class ProductEntity
    {
        [Key]
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
