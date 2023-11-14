using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Ques2.Models
{
    public class Movies
    {
        [Key]
        public int mid { get; set; }
        public string mname { get; set; }
        public DateTime dateofrelease { get; set; }
    }
}