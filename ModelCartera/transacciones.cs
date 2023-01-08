using System;

namespace ModelCartera
{
    public class transacciones
    {
        //Atributos de clase
        public int Id { get; set; }
        public string Accion { get; set; }
        public DateTime Fecha { get; set; }
        public string Modulo { get; set; }
        public string Registro { get; set; }
        public string Usuario { get; set; }
    }
}
