using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJet.Models.Dto
{
    public class ProductDto
    {
        [Required]
        public string nm_product { get; set; }
        [Required]
        public IFormFile img_principal { get; set; }
        [Required]
        public IFormFile img_secundary { get; set; }
        [Required]
        public string ds_product { get; set; }
        [Required]
        public int inventory { get; set; }
        [Required]
        public bool status { get; set; }
        [Required]
        public double price { get; set; }
        [Required]
        public double promocional_price { get; set; }


    }
}
