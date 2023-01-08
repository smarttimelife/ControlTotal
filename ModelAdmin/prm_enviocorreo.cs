namespace ModelAdmin
{
    public class prm_enviocorreo : baseViewModel
    {
        // Atributos de clase

        private string _id;
        private string _correodesde;
        private string _clave;
        private string _host;
        private string _puerto;

        // constructor

        public prm_enviocorreo()
        { }

        public prm_enviocorreo(string id, string correodesde, string clave, string host, string puerto)
        {
            this._id = id;
            this._correodesde = correodesde;
            this._clave = clave;
            this._host = host;
            this._puerto = puerto;
        }

        // Propiedades

        public string id
        {
            get { return _id; }
            set { SetValue(ref _id, value); }
        }

        public string correodesde
        {
            get { return _correodesde; }
            set { SetValue(ref _correodesde, value); }
        }

        public string clave
        {
            get { return _clave; }
            set { SetValue(ref _clave, value); }
        }

        public string host
        {
            get { return _host; }
            set { SetValue(ref _host, value); }
        }

        public string puerto
        {
            get { return _puerto; }
            set { SetValue(ref _puerto, value); }
        }
    }
}