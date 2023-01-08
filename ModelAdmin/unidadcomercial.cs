namespace ModelAdmin
{
    public class unidadcomercial : baseViewModel
    {
        // Atributos de clase

        private int _IdUnidad;
        private string _Abreviatura;
        private string _Descripcion;
        private int _Piezas;
        private bool _PermitirFraccion;
        private int _IdTransaccion;

        // constructor

        public unidadcomercial()
        { }

        public unidadcomercial(int IdUnidad, string Abreviatura, string Descripcion, int Piezas, bool PermitirFraccion, int IdTransaccion)
        {
            this._IdUnidad = IdUnidad;
            this._Abreviatura = Abreviatura;
            this._Descripcion = Descripcion;
            this._Piezas = Piezas;
            this._PermitirFraccion = PermitirFraccion;
            this._IdTransaccion = IdTransaccion;
        }

        // Propiedades

        public int IdUnidad
        {
            get { return _IdUnidad; }
            set { SetValue(ref _IdUnidad, value); }
        }

        public string Abreviatura
        {
            get { return _Abreviatura; }
            set { SetValue(ref _Abreviatura, value); }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { SetValue(ref _Descripcion, value); }
        }

        public int Piezas
        {
            get { return _Piezas; }
            set { SetValue(ref _Piezas, value); }
        }

        public bool PermitirFraccion
        {
            get { return _PermitirFraccion; }
            set { SetValue(ref _PermitirFraccion, value); }
        }

        public int IdTransaccion
        {
            get { return _IdTransaccion; }
            set { SetValue(ref _IdTransaccion, value); }
        }
    }
}