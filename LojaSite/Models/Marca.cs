using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaSite.Models
{
    public class Marca
    {
        [Key]
        public int Id_marca { get; set; }

        public String Nm_merca { get; set; }
    }
}