namespace ModelAdmin
{
    public class conexiones : baseViewModel
    {
        // Atributos de clase

        private int _Id;
        private int _IdProyecto;
        private int _IdSoftware;
        private string _Servidor;
        private string _BaseDatos;
        private string _Puerto;

        // constructor

        public conexiones()
        { }

        public conexiones(int Id, int IdProyecto, int IdSoftware, string Servidor, string BaseDatos, string Puerto)
        {
            this._Id = Id;
            this._IdProyecto = IdProyecto;
            this._IdSoftware = IdSoftware;
            this._Servidor = Servidor;
            this._BaseDatos = BaseDatos;
            this._Puerto = Puerto;
        }

        // Propiedades

        public int Id
        {
            get { return _Id; }
            set { SetValue(ref _Id, value); }
        }

        public int IdProyecto
        {
            get { return _IdProyecto; }
            set { SetValue(ref _IdProyecto, value); }
        }

        public int IdSoftware
        {
            get { return _IdSoftware; }
            set { SetValue(ref _IdSoftware, value); }
        }

        public string Servidor
        {
            get { return _Servidor; }
            set { SetValue(ref _Servidor, value); }
        }

        public string BaseDatos
        {
            get { return _BaseDatos; }
            set { SetValue(ref _BaseDatos, value); }
        }

        public string Puerto
        {
            get { return _Puerto; }
            set { SetValue(ref _Puerto, value); }
        }
    }
}