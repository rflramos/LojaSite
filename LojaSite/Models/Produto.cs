using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaSite.Models
{
    [Table("T_PRODUTO")]
    public class Produto
    {
        [Key]
        [Column("ID_PRODUTO")]
        public int Id_produto { get; set; }

        [Column("NM_PRODUTO")]
        public String Nm_produto { get; set; }

        [Column("VL_PRODUTO")]
        public double Vl_produto { get; set; }

        [Column("T_MERCADO_ID_MERCADO")]
        public int T_mercado_id_mercado { get; set; }

        [Column("T_MARCA_ID_MARCA")]
        public int T_marca_id_marca { get; set; }


               
    }
}