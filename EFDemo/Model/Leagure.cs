using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFDemo.Model
{
    public class Leagure
    {
        public int Id { get; set; }
        [MaxLength(100), Required]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
    }
}
