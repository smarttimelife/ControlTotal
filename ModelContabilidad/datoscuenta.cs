
namespace ModelContabilidad
{
    public class datoscuenta
    {
        //Atributos de clase
        public int Id { get; set; }
        public string Operacion { get; set; }
        public string Debe { get; set; }
        public string Haber { get; set; }
        public int IdTransaccionesAuto { get; set; }
        public string Documento { get; set; }
    }
}
