using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.MVC.Models
{
    public class Cliente
    {
        public int cod_cliente { get; set; }
        public string txt_cliente { get; set; }
        public string txt_telefone { get; set; }
        public string txt_telefone2 { get; set; }
        public string txt_instagram { get; set; }
        public int cod_cidade { get; set; }
        public string txt_endereco { get; set; }
        public string txt_complemento { get; set; }
        public string txt_descricao { get; set; }
    }
}