using System;

namespace ModelCartera
{
    public class reservas
    {
        //Atributos de clase
        public int Id { get; set; }
        public string IdReserva { get; set; }
        public DateTime Fecha { get; set; }
        public string Contrato { get; set; }
        public string IdProyecto { get; set; }
        public string IdInmueble { get; set; }
        public string IdTercero { get; set; }
        public string IdGestor { get; set; }
        public decimal ValorContrato { get; set; }
        public decimal ValorPago1 { get; set; }
        public DateTime FechaInicio { get; set; }
        public string Letra { get; set; }
        public string Estado { get; set; }
        public int IdTransaccion { get; set; }
    }
}
