using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Web.MVC.Models;

namespace Web.MVC.ViewModel
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            result = new Result();
        }

        [Key]
        public int cod_cliente { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string txt_cliente { get; set; }

        [Required]
        [Display(Name = "Telefone")]
        public string txt_telefone { get; set; }   
             
        [Display(Name = "Telefone")]
        public string txt_telefone2 { get; set; }
        
        [Display(Name = "Instagram")]
        public string txt_instagram { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public int cod_estado { get; set; }

        [Required]
        [Display(Name = "Cidade")]
        public int cod_cidade { get; set; }

        [Required]
        [Display(Name = "Endereço")]
        public string txt_endereco { get; set; }
        
        [Display(Name = "Complemento")]
        public string txt_complemento { get; set; }
        
        [Display(Name = "Observação")]
        public string txt_descricao { get; set; }

        public Result result { get; set; }
    }
}