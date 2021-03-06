﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Planter_API.Models
{
    public class Climates
    {
        [Key]
        public int ClimateID { get; set; }
        public string Climate { get; set; }

        //Relationships 
        public List<Plants> Plants { get; set;}
    }
}
