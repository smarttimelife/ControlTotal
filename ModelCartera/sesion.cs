using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCartera
{
    public class sesion
    {
        public int IdSesion { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string IdAdjudicacion { get; set; }
        public string IdTercero1 { get; set; }
        public string IdTercero2 { get; set; }
        public string IdTercero3 { get; set; }
        public string NuevoIdTercero1 { get; set; }
        public string NuevoIdTercero2 { get; set; }
        public string NuevoIdTercero3 { get; set; }
        public string UsuarioElabora { get; set; }
        public string UsuarioAprueba { get; set; }
        public DateTime FechaAprobacion { get; set; }
        public string Estado { get; set; }

    }
}
