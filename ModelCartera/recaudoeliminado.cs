using System;

namespace ModelCartera
{
    public class recaudoeliminado
    {
        //Atributos de clase
        public int IdEliminado { get; set; }
        public string IdRecaudo { get; set; }
        public string IdAdjudicacion { get; set; }
        public string Recibo { get; set; }
        public DateTime Fecha { get; set; }
        public int NumCuota { get; set; }
        public string Concepto { get; set; }
        public decimal Capital { get; set; }
        public decimal InteresCte { get; set; }
        public decimal InteresMora { get; set; }
        public decimal InteresCnd { get; set; }
        public decimal CapitalCnd { get; set; }
        public decimal Otros { get; set; }
        public decimal VrMoraCalc { get; set; }
        public string Estado { get; set; }
        public string IdFinanciacion { get; set; }
        public int Periodo { get; set; }
        public DateTime FechaCuota { get; set; }
        public DateTime FechaEliminacion { get; set; }
        public string UsuarioElimina { get; set; }
        public int IdTransaccion { get; set; }
    }
}
