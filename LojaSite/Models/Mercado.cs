using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaSite.Models
{
    [Table("T_MERCADO")]
    public class Mercado
    {
        [Key]
        [Column("ID_MERCADO")]
        public int Id_mercado { get; set; }
        
        [Column("NM_MERCADO")]
        public String Nm_mercado { get; set; }
    }
}