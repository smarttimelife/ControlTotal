namespace ModelAdmin
{
    public class productos : baseViewModel
    {
        // Atributos de clase

        private string _IdProductos;
        private string _NombreProducto;
        private int _IdCategoria;
        private int _IdUndCial;
        private int _IdTransaccion;

        // constructor

        public productos()
        { }

        public productos(string IdProductos, string NombreProducto, int IdCategoria, int IdUndCial, int IdTransaccion)
        {
            this._IdProductos = IdProductos;
            this._NombreProducto = NombreProducto;
            this._IdCategoria = IdCategoria;
            this._IdUndCial = IdUndCial;
            this._IdTransaccion = IdTransaccion;
        }

        // Propiedades

        public string IdProductos
        {
            get { return _IdProductos; }
            set { SetValue(ref _IdProductos, value); }
        }

        public string NombreProducto
        {
            get { return _NombreProducto; }
            set { SetValue(ref _NombreProducto, value); }
        }

        public int IdCategoria
        {
            get { return _IdCategoria; }
            set { SetValue(ref _IdCategoria, value); }
        }

        public int IdUndCial
        {
            get { return _IdUndCial; }
            set { SetValue(ref _IdUndCial, value); }
        }

        public int IdTransaccion
        {
            get { return _IdTransaccion; }
            set { SetValue(ref _IdTransaccion, value); }
        }
    }
}