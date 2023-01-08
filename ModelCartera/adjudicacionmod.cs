using System;

namespace ModelCartera
{
    public class adjudicacionmod
    {
        //Atributos de clase
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string IdAdjudicacion { get; set; }
        public string Contrato { get; set; }
        public string IdProyecto { get; set; }
        public string IdInmueble { get; set; }
        public string IdTercero1 { get; set; }
        public string IdTercero2 { get; set; }
        public string IdTercero3 { get; set; }
        public string FormaPago { get; set; }
        public decimal Valor { get; set; }
        public decimal CuotaInicial { get; set; }
        public decimal Contado { get; set; }
        public decimal Financiacion { get; set; }
        public decimal Extraordinaria { get; set; }
        public int PlazoFnc { get; set; }
        public decimal TasaFnc { get; set; }
        public decimal CuotaFnc { get; set; }
        public DateTime InicioFnc { get; set; }
        public int PlazoExtra { get; set; }
        public decimal TasaExtra { get; set; }
        public decimal CuotaExtra { get; set; }
        public DateTime InicioExtra { get; set; }
        public string Estado { get; set; }
        public decimal Porcentaje { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string OrigenVenta { get; set; }
        public string TipoOrigen { get; set; }
        public decimal BaseComision { get; set; }
        public string Radicado { get; set; }
        public DateTime FechaRadicacion { get; set; }
        public DateTime FechaContrato { get; set; }
        public string UsuarioRadica { get; set; }
        public string Oficina { get; set; }
        public string Inmueble_desistido { get; set; }
        public string Equipo { get; set; }
        public string Url { get; set; }
        public int IdTransaccion { get; set; }
        public int PeriodoFnc { get; set; }
        public int PeriodoExtra { get; set; }
    }
}
