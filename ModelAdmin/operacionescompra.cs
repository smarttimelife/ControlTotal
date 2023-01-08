namespace ModelAdmin
{
    public class operacionescompra : baseViewModel
    {
        // Atributos de clase

        private int _Id;
        private string _Nombre;
        private int _software;

        // constructor

        public operacionescompra()
        { }

        public operacionescompra(int Id, string Nombre, int software)
        {
            this._Id = Id;
            this._Nombre = Nombre;
            this._software = software;
        }

        // Propiedades

        public int Id
        {
            get { return _Id; }
            set { SetValue(ref _Id, value); }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { SetValue(ref _Nombre, value); }
        }

        public int software
        {
            get { return _software; }
            set { SetValue(ref _software, value); }
        }
    }
}