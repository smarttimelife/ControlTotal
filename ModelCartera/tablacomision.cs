
namespace ModelCartera
{
    public class tablacomision
    {
        //Atributos de clase
        public int Id { get; set; }
        public string IdCargo { get; set; }
        public string NombreCargo { get; set; }
        public string IdTercero { get; set; }
        public decimal Normal { get; set; }
        public decimal Comercial { get; set; }
        public decimal GerenteGral { get; set; }
        public decimal GerenteFin { get; set; }
        public decimal GerenteAdmin { get; set; }
        public int IdTransaccion { get; set; }
    }
}
