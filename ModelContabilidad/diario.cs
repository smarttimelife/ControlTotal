using System;

namespace ModelContabilidad
{
    public class diario
    {
        //Atributos de clase
        public int IdDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public string Cuenta { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
        public int Consecutivo { get; set; }
        public string Motivo { get; set; }
        public string Detalle { get; set; }
        public string Cheque { get; set; }
        public string Fuente { get; set; }
        public string IdTercero { get; set; }
        public decimal BaseRetencion { get; set; }
        public int Periodo { get; set; }
        public int CentroCostos { get; set; }
        public int SubCentro { get; set; }
        public int Estado { get; set; }
        public int Transaccion { get; set; }
        public string Beneficiario { get; set; }
        public string Factura { get; set; }
        public int Orden { get; set; }
        public DateTime Vencimiento { get; set; }
        public string Matricula { get; set; }
        public string CruceCartera { get; set; }
        public bool Programada { get; set; }
        public string Autorizacion { get; set; }
        public string SubSubCentro { get; set; }
        public string OldPuc { get; set; }
        public string EstadoCheque { get; set; }
        public DateTime Fechapagocheque { get; set; }
        public int Id { get; set; }
    }
}
