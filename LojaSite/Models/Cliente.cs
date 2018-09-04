using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace LojaSite.Models
{
    [Table("T_CLIENTE")]
    public class Cliente
    {
        [Key]
        [Column("ID_CLIENTE")]
        public int Id_cliente { get; set; }

        [Column("NM_CLIENTE")]
        public String Nm_cliente { get; set; }

        [Column("NR_RG")]
        public String Nr_rg { get; set; }

        [Column("T_MERCADO_ID_MERCADO")]
        public int T_mercado_id_mercado { get; set; }

    }
}