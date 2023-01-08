namespace ModelAdmin
{
    public class tipotercero : baseViewModel
    {
        // Atributos de clase

        private int _Id;
        private int _IdTipoTercero;
        private string _TipoTercero;

        // constructor

        public tipotercero()
        { }

        public tipotercero(int Id, int IdTipoTercero, string TipoTercero)
        {
            this._Id = Id;
            this._IdTipoTercero = IdTipoTercero;
            this._TipoTercero = TipoTercero;
        }

        // Propiedades

        public int Id
        {
            get { return _Id; }
            set { SetValue(ref _Id, value); }
        }

        public int IdTipoTercero
        {
            get { return _IdTipoTercero; }
            set { SetValue(ref _IdTipoTercero, value); }
        }

        public string TipoTercero
        {
            get { return _TipoTercero; }
            set { SetValue(ref _TipoTercero, value); }
        }
    }
}