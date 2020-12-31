using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Web.MVC.Models;

namespace Web.MVC.ViewModel
{
    public class PaisViewModel
    {
        public PaisViewModel()
        {
            result = new Result();
        }

        [Key]
        public int cod_pais { get; set; }

        [Required]
        [Display(Name = "País")]
        public string txt_pais { get; set; }

        public Result result { get; set; }
    }
}