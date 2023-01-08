namespace ModelAdmin
{
    public class proveedores : baseViewModel
    {
        // Atributos de clase

        private string _IdTercero;
        private string _TipoDocumento;
        private string _NoDocumento;
        private int _IdCategoria;

        // constructor

        public proveedores()
        { }

        public proveedores(string IdTercero, string TipoDocumento, string NoDocumento, int IdCategoria)
        {
            this._IdTercero = IdTercero;
            this._TipoDocumento = TipoDocumento;
            this._NoDocumento = NoDocumento;
            this._IdCategoria = IdCategoria;
        }

        // Propiedades

        public string IdTercero
        {
            get { return _IdTercero; }
            set { SetValue(ref _IdTercero, value); }
        }

        public string TipoDocumento
        {
            get { return _TipoDocumento; }
            set { SetValue(ref _TipoDocumento, value); }
        }

        public string NoDocumento
        {
            get { return _NoDocumento; }
            set { SetValue(ref _NoDocumento, value); }
        }

        public int IdCategoria
        {
            get { return _IdCategoria; }
            set { SetValue(ref _IdCategoria, value); }
        }
    }
}