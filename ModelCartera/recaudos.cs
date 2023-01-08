using System;

namespace ModelCartera
{
    public class recaudos
    {
        //Atributos de clase
        public string IdRecaudo { get; set; }
        public string IdFinanciacion { get; set; }
        public string IdAdjudicacion { get; set; }
        public string Proyecto { get; set; }
        public string Recibo { get; set; }
        public DateTime Fecha { get; set; }
        public int CuotaNumero { get; set; }
        public string Concepto { get; set; }
        public decimal Capital { get; set; }
        public decimal InteresCte { get; set; }
        public decimal InteresMora { get; set; }
        public decimal InteresCnd { get; set; }
        public decimal CapitalCnd { get; set; }
        public decimal Otros { get; set; }
        public decimal VrMoraCalc { get; set; }
        public DateTime FechaOperacion { get; set; }
        public string Usuario { get; set; }
        public string Estado { get; set; }
        public int Periodo { get; set; }
        public DateTime FechaCuota { get; set; }
        public string NoBoleta { get; set; }
    }
}
