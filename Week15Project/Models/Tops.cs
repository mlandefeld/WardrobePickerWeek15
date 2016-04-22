using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week15Project.Models
{
    public class Tops
    {
        [Key]/*The key indicates that 'TopID' is the ID for Tops and will not be viewed in the frontend.*/
        public int TopID { get; set; }
        public string Nickname { get; set; }
        public string Photo { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Season { get; set; }
        public string Occasion { get; set; }
    }
}