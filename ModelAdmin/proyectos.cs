namespace ModelAdmin
{
    public class proyectos : baseViewModel
    {
        // Atributos de clase

        private int _Id;
        private string _NombreProyecto;
        private int _IdEmpresa;
        private int _Mostrar;

        // constructor

        public proyectos()
        { }

        public proyectos(int Id, string NombreProyecto, int IdEmpresa, int Mostrar)
        {
            this._Id = Id;
            this._NombreProyecto = NombreProyecto;
            this._IdEmpresa = IdEmpresa;
            this._Mostrar = Mostrar;
        }

        // Propiedades

        public int Id
        {
            get { return _Id; }
            set { SetValue(ref _Id, value); }
        }

        public string NombreProyecto
        {
            get { return _NombreProyecto; }
            set { SetValue(ref _NombreProyecto, value); }
        }

        public int IdEmpresa
        {
            get { return _IdEmpresa; }
            set { SetValue(ref _IdEmpresa, value); }
        }

        public int Mostrar
        {
            get { return _Mostrar; }
            set { SetValue(ref _Mostrar, value); }
        }
    }
}