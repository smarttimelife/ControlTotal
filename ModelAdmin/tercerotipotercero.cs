namespace ModelAdmin
{
    public class tercerotipotercero : baseViewModel
    {
        // Atributos de clase

        private int _Id;
        private string _IdTercero;
        private int _IdTipoTercero;

        // constructor

        public tercerotipotercero()
        { }

        public tercerotipotercero(int Id, string IdTercero, int IdTipoTercero)
        {
            this._Id = Id;
            this._IdTercero = IdTercero;
            this._IdTipoTercero = IdTipoTercero;
        }

        // Propiedades

        public int Id
        {
            get { return _Id; }
            set { SetValue(ref _Id, value); }
        }

        public string IdTercero
        {
            get { return _IdTercero; }
            set { SetValue(ref _IdTercero, value); }
        }

        public int IdTipoTercero
        {
            get { return _IdTipoTercero; }
            set { SetValue(ref _IdTipoTercero, value); }
        }
    }
}