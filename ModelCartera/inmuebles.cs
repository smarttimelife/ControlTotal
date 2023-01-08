using System;
using System.ComponentModel.DataAnnotations;

namespace ModelCartera
{
    public class inmuebles
    {
        //Atributos de clase
        public int Id { get; set; }
        [Key]
        public string IdInmueble { get; set; }
        public string IdProyecto { get; set; }
        public string Etapa { get; set; }
        public string Manzana { get; set; }
        public string Lote { get; set; }
        public string Matricula { get; set; }
        public decimal Valor { get; set; }
        public string Estado { get; set; }
        public DateTime InicioObra { get; set; }
        public DateTime FinObra { get; set; }
        public decimal AreaPrivada { get; set; }
        public decimal AreaConstruida { get; set; }
        public string MZ { get; set; }
        public string LT { get; set; }
        public decimal AREA_LT { get; set; }
        public decimal AREA_MZ { get; set; }
        public decimal NORTE { get; set; }
        public string LINDERO_NORTE { get; set; }
        public string COLINDANTE_NORTE { get; set; }
        public decimal SUR { get; set; }
        public string LINDERO_SUR { get; set; }
        public string COLINDANTE_SUR { get; set; }
        public decimal ESTE { get; set; }
        public string LINDERO_ESTE { get; set; }
        public string COLIDANTE_ESTE { get; set; }
        public decimal OESTE { get; set; }
        public string LINDERO_OESTE { get; set; }
        public string COLINDANTE_OESTE { get; set; }
        public decimal FAC_VALOR_VIA_PRINCIPAL { get; set; }
        public decimal FAC_VALOR_AREA_SOCIAL { get; set; }
        public decimal FAC_VALOR_ESQUINERO { get; set; }
        public int IdTransaccion { get; set; }
    }
}
