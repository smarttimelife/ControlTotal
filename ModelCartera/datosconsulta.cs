using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCartera
{
    public class datosconsulta
    {
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public int Periodo { get; set; }
        public string IdAdjudicacion { get; set; }
        public string IdTercero { get; set; }
    }
}
