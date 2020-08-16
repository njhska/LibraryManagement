﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFDemo.Model
{
    public class Club
    {
        public Club()
        {
            Players = new List<Player>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string History { get; set; }
        public string City { get; set; }
        [Column(TypeName = "date")]
        public DateTime CreateTime { get; set; }
        public Leagure Leagure { get; set; }
        public List<Player> Players { get; set; }
    }
}
