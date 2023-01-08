namespace ModelAdmin
{
    public class categorias : baseViewModel
    {
        // Atributos de clase

        private int _IdCategoria;
        private string _Descripcion;
        private string _Iniciales;
        private string _Consecutivo;

        // constructor

        public categorias()
        { }

        public categorias(int IdCategoria, string Descripcion, string Iniciales, string Consecutivo)
        {
            this._IdCategoria = IdCategoria;
            this._Descripcion = Descripcion;
            this._Iniciales = Iniciales;
            this._Consecutivo = Consecutivo;
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

        public string Iniciales
        {
            get { return _Iniciales; }
            set { SetValue(ref _Iniciales, value); }
        }

        public string Consecutivo
        {
            get { return _Consecutivo; }
            set { SetValue(ref _Consecutivo, value); }
        }
    }
}