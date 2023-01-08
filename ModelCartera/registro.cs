using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelCartera
{
    public class registro
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Modulo { get; set; }
        public String Accion { get; set; }
        public String Usuario { get; set; }
        public String Registro { get; set; }
        public String Respaldo { get; set; }
     
    }
}
