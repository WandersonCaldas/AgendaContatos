using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Web.MVC.Models;

namespace Web.MVC.ViewModel
{
    public class LoginViewModel
    {
        public LoginViewModel()
        {
            result = new Result();           
        }

        [Required]
        [Display(Name = "Usuário")]        
        public string txt_login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string txt_senha { get; set; }

        [Key]
        public int cod_usuario { get; set; }        
        public bool st_ativo { get; set; }        
        public Result result { get; set; }
    }
}