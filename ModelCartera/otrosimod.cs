using System;

namespace ModelCartera
{
    public class otrosimod
    {
        //Atributos de clase
        public int Id { get; set; }
        public int IdOtrosi { get; set; }
        public DateTime Fecha { get; set; }
        public string IdAdjudicacion { get; set; }
        public decimal RecaudoTotal { get; set; }
        public decimal CapitalInicial { get; set; }
        public decimal NuevoCapital { get; set; }
        public decimal FinanciacionInicial { get; set; }
        public decimal NuevoFinanciacion { get; set; }
        public int PlazoInicialFnc { get; set; }
        public int NuevoPlazoFnc { get; set; }
        public decimal TasaInicialFnc { get; set; }
        public decimal NuevoTasaFnc { get; set; }
        public decimal CuotaFncInicial { get; set; }
        public decimal NuevoCuotaFnc { get; set; }
        public decimal CuotaIniInicial { get; set; }
        public decimal NuevoCuotaIni { get; set; }
        public decimal ExtraordinariaInicial { get; set; }
        public decimal NuevoExtraordinaria { get; set; }
        public int PlazoExtraInicial { get; set; }
        public int NuevoPlazoExtra { get; set; }
        public decimal TasaExtraInicial { get; set; }
        public decimal NuevoTasaExtra { get; set; }
        public decimal CuotaExtraInicial { get; set; }
        public decimal NuevoCuotaExtra { get; set; }
        public string Estado { get; set; }
        public string DatosCorrido { get; set; }
        public int CantidadCorrida { get; set; }
        public int PrimeraCuotaCorrida { get; set; }
        public int UltimaCuotaCorrida { get; set; }
        public string Observacion { get; set; }
        public int IdTransaccion { get; set; }
    }
}
