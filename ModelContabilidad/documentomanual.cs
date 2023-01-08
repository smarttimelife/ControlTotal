
namespace ModelContabilidad
{
    public class documentomanual
    {
        //Atributos de clase
        public string idComprobante { get; set; }
        public string NombreComprobante { get; set; }
        public int Consecutivo { get; set; }
        public int IdTipoDocumento { get; set; }
        public string Cuenta { get; set; }
        public int ConsecutivoRef { get; set; }
        public bool Automatico { get; set; }
    }
}
