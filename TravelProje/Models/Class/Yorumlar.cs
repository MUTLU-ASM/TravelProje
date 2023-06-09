﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProje.Models.Class
{
    public class Yorumlar
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int BlogID { get; set; }
        public virtual Blog Blog{ get; set; }
    }
}