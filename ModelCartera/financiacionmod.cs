using System;

namespace ModelCartera
{
    public class financiacionmod
    {
        //Atributos de clase
        public int Id { get; set; }
        public string IdFinanciacion { get; set; }
        public string IdAdjudicacion { get; set; }
        public string Concepto { get; set; }
        public int CuotaNumero { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Capital { get; set; }
        public decimal Interes { get; set; }
        public decimal Cuota { get; set; }
        public int IdTransaccion { get; set; }
    }
}
