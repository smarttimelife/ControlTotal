namespace ModelAdmin
{
    public class subcentro : baseViewModel
    {
        // Atributos de clase

        private int _IdSubcentro;
        private string _Nombre;

        // constructor

        public subcentro()
        { }

        public subcentro(int IdSubcentro, string Nombre)
        {
            this._IdSubcentro = IdSubcentro;
            this._Nombre = Nombre;
        }

        // Propiedades

        public int IdSubcentro
        {
            get { return _IdSubcentro; }
            set { SetValue(ref _IdSubcentro, value); }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { SetValue(ref _Nombre, value); }
        }
    }
}