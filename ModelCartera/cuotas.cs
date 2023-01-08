using System;

namespace ModelCartera
{
    public class cuotas
    {
        public decimal Cuota { get; set; }
        public decimal Capital { get; set; }
        public decimal Interes { get; set; }
        public string Concepto { get; set; }
        public int CuotaNumero { get; set; }
        public DateTime Fecha { get; set; }
    }
}
