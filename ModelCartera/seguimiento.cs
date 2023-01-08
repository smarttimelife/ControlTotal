using System;

namespace ModelCartera
{
    public class seguimiento
    {
        //Atributos de clase
        public int IdSeguimiento { get; set; }
        public string IdAdjudicacion { get; set; }
        public string Proyecto { get; set; }
        public DateTime Fecha { get; set; }
        public string Titular { get; set; }
        public string Inmueble { get; set; }
        public string Accion { get; set; }
        public string Objecion { get; set; }
        public string Compromiso { get; set; }
        public DateTime FechaCompromiso { get; set; }
        public string TipoCartera { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
    }
}
