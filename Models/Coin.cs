using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_APIs_Problema_2._2.Models
{
    public class Coin
    {
        [StringLength(10, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        public int Value { get; set; }
    }
}