namespace ModelAdmin
{
    public class usuarios_proyectos : baseViewModel
    {
        // Atributos de clase

        private int _Id;
        private int _IdUsuario;
        private int _IdProyecto;
        private int _IdSoftware;

        // constructor

        public usuarios_proyectos()
        { }

        public usuarios_proyectos(int Id, int IdUsuario, int IdProyecto, int IdSoftware)
        {
            this._Id = Id;
            this._IdUsuario = IdUsuario;
            this._IdProyecto = IdProyecto;
            this._IdSoftware = IdSoftware;
        }

        // Propiedades

        public int Id
        {
            get { return _Id; }
            set { SetValue(ref _Id, value); }
        }

        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { SetValue(ref _IdUsuario, value); }
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
    }
}