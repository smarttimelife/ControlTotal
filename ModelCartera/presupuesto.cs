using System;

namespace ModelCartera
{
    public class presupuesto
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
        public string TitularPrincipal { get; set; }
        public string TipoCartera { get; set; }
        public string Estado { get; set; }
        public DateTime UltimoPago { get; set; }
        public string IdInmueble { get; set; }
        public decimal RcdCapital { get; set; }
        public decimal RcdInteresCte { get; set; }
        public int Mora { get; set; }
        public decimal SdoCapital { get; set; }
        public decimal SdoInteres { get; set; }
        public decimal SdoCuota { get; set; }
        public int Periodo { get; set; }
        public int Rango { get; set; }
    }
}
