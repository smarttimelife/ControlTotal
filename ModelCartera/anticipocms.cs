using System;

namespace ModelCartera
{
    public class anticipocms
    {
        //Atributos de clase
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string IdAnticpo { get; set; }
        public string IdAdjudicacion { get; set; }
        public string IdCargo { get; set; }
        public string IdGestor { get; set; }
        public decimal Valor { get; set; }
        public int IdTransaccion { get; set; }
    }
}
