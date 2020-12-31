using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.MVC.Models
{
    public class Usuario
    {        
        public int cod_usuario { get; set; }
        public string txt_login { get; set; }
        public string txt_senha { get; set; }                
        public bool st_ativo { get; set; }       
    }
}