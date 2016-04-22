using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week15Project.Models
{
    public class Accessories
    {
        [Key]/*The key indicates that 'AccessoryID' is the ID for Accessories and will not be viewed in the frontend.*/
        public int AccessoryID { get; set; }
        public string Nickname { get; set; }
        public string Photo { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Season { get; set; }
        public string Occasion { get; set; }

    }
}