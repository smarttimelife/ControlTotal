using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCartera
{
    public class transaccionCont
    {
        
            //Atributos de clase
            public int IdTransaccion { get; set; }
            public DateTime Fecha { get; set; }
            public string Transaccion { get; set; }
            public string Fuente { get; set; }
            public int Registro { get; set; }
            public string Usuario { get; set; }
        
    }
}
