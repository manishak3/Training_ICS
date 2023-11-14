using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Codefirstq2.Models
{
    public class movie
    {
        [Key]
        public int mid { get; set; }
        public string moviename { get; set; }
        public string moviedate { get; set; }
    }
}