using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCartera
{
    public class Log
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public string Accion { get; set; }
        public string Modulo { get; set; }
        public string Registro { get; set; }
        public string Logs { get; set; }
    }
}
