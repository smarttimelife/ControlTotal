using System;

namespace ModelCartera
{
    public class pagocomision
    {
        //Atributos de clase
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string IdAdjudicacion { get; set; }
        public string IdComision { get; set; }
        public string Idgestor { get; set; }
        public string IdCargo { get; set; }
        public decimal TasaComision { get; set; }
        public decimal Comision { get; set; }
        public decimal ReteFuente { get; set; }
        public decimal DctoAnticipo { get; set; }
        public decimal PagoNeto { get; set; }
        public int Veces { get; set; }
        public int Veriact { get; set; }
        public int IdTransaccion { get; set; }
    }

    public class DatosComsion
    {
        public string BaseDatos { get; set; }
        public int CentroCostos { get; set; }
        public string IdAdjudicacion { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public decimal TotalComision { get; set; }
    }
}
