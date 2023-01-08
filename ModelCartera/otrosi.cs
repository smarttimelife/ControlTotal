using System;
using System.ComponentModel.DataAnnotations;

namespace ModelCartera
{
    public class otrosi
    {
        //Atributos de clase
        public int Id { get; set; }
        [Key]
        public int IdOtrosi { get; set; }
        public DateTime Fecha { get; set; }
        public string IdAdjudicacion { get; set; }
        public decimal Capital { get; set; }
        public decimal RecaudoTotal { get; set; }
        public decimal NuevoCapital { get; set; }
        public decimal Financiacion { get; set; }
        public decimal NuevoFinanciacion { get; set; }
        public int PlazoFnc { get; set; }
        public int NuevoPlazoFnc { get; set; }
        public decimal TasaFnc { get; set; }
        public decimal NuevoTasaFnc { get; set; }
        public decimal CuotaFnc { get; set; }
        public decimal NuevoCuotaFnc { get; set; }
        public int PeriodoFnc { get; set; }
        public DateTime InicioFnc { get; set; }
        public decimal CuotaInicial { get; set; }
        public decimal NuevoCuotaInicial { get; set; }
        public decimal Extraordinaria { get; set; }
        public decimal NuevoExtraordinaria { get; set; }
        public int PlazoExtra { get; set; }
        public int NuevoPlazoExtra { get; set; }
        public decimal TasaExtra { get; set; }
        public decimal NuevoTasaExtra { get; set; }
        public decimal Contado { get; set; }
        public decimal NuevoContado { get; set; }
        public decimal CuotaExtra { get; set; }
        public int PeriodoExtra { get; set; }
        public decimal NuevoCuotaExtra { get; set; }
        public DateTime InicioExtra { get; set; }
        public string DatosCorrido { get; set; }
        public int CantidadCorrida { get; set; }
        public int PrimeraCuotaCorrida { get; set; }
        public string FormaPago { get; set; }
        public string NuevaFormaPago { get; set; }
        public int UltimaCuotaCorrida { get; set; }
        public decimal AbonoCapital { get; set; }
        public DateTime FechaAbono { get; set; }
        public string Observacion { get; set; }
        public int IdTransaccion { get; set; }
        public string Estado { get; set; }
    }
}
