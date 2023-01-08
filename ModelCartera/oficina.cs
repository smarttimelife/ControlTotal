
namespace ModelCartera
{
    public class oficina
    {
        //Atributos de clase
        public int Id { get; set; }
        public string NombreOficina { get; set; }
        public decimal Mora { get; set; }
        public decimal IntCorriente { get; set; }
        public decimal Porcentaje { get; set; }
        public int Periodo { get; set; }
        public int LqdMora { get; set; }
        public double ValorMinRadicar { get; set; }
        public int IdTransaccion { get; set; }
        public bool Automatico { get; set; }
    }
}
