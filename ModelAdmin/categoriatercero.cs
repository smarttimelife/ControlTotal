namespace ModelAdmin
{
    public class categoriatercero : baseViewModel
    {
        // Atributos de clase

        private int _IdCategoria;
        private string _Descripcion;

        // constructor

        public categoriatercero()
        { }

        public categoriatercero(int IdCategoria, string Descripcion)
        {
            this._IdCategoria = IdCategoria;
            this._Descripcion = Descripcion;
        }

        // Propiedades

        public int IdCategoria
        {
            get { return _IdCategoria; }
            set { SetValue(ref _IdCategoria, value); }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { SetValue(ref _Descripcion, value); }
        }
    }
}