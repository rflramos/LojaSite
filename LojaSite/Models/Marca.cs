using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LojaSite.Models
{
    [Table("T_MARCA")]
    public class Marca
    {
        [Key]
        [Column("ID_MARCA")]
        public int Id_marca { get; set; }

        [Column("NM_MARCA")]
        public String Nm_marca { get; set; }
    }
}