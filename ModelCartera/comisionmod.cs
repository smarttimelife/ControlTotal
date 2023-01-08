using System;

namespace ModelCartera
{
    public class comisionmod
    {
        //Atributos de clase
        public string Id { get; set; }
        public string IdAdjudicacion { get; set; }
        public DateTime Fecha { get; set; }
        public string IdGestor { get; set; }
        public string IdCargo { get; set; }
        public decimal Comision1 { get; set; }
        public decimal Comision2 { get; set; }
        public string Estado { get; set; }
        public int IdTransaccion { get; set; }
    }
}
