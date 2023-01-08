using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ModelCartera
{
   public class ViewEstadoCuenta
    {
        public DateTime Fecha { get; set; }
        public string IdAdjudicacion { get; set; }
        public string IdFinanciacion { get; set; }
        public string Concepto { get; set; }
        public int CuotaNumero { get; set; }
        public decimal Capital { get; set; }
        public decimal Interes { get; set; }
        public decimal Cuota { get; set; }
        public decimal SdoCapital { get; set; }
        public decimal SdoInteres { get; set; }
        public decimal SdoCuota { get; set; }
        public decimal Mora { get; set; }
        public decimal VrMora { get; set; }

    }
}
