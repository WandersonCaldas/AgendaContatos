using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Web.MVC.Models.Config
{
    public class PaisConfig : EntityTypeConfiguration<Pais>
    {
        public PaisConfig()
        {
            HasKey(p => p.cod_pais);

            ToTable("tbl_pais");
        }
    }
}