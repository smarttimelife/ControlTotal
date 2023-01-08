using System;

namespace ModelCartera
{
    public class datosrecaudosmod
    {
        //Atributos de clase
        public int Id { get; set; }
        public int IdRecaudo { get; set; }
        public string IdAdjudicacion { get; set; }
        public DateTime Fecha { get; set; }
        public string Recibo { get; set; }
        public string IdTercero { get; set; }
        public string Operacion { get; set; }
        public decimal Valor { get; set; }
        public string CodBanco { get; set; }
        public string FormaPago { get; set; }
        public string NoBoleta { get; set; }
        public int IdTransaccion { get; set; }
        public int TransaccionContab { get; set; }
    }
}
