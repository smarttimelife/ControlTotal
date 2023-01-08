namespace ModelAdmin
{
    public class tipopersonas : baseViewModel
    {
        // Atributos de clase

        private int _Id;
        private string _Detalle;

        // constructor

        public tipopersonas()
        { }

        public tipopersonas(int Id, string Detalle)
        {
            this._Id = Id;
            this._Detalle = Detalle;
        }

        // Propiedades

        public int Id
        {
            get { return _Id; }
            set { SetValue(ref _Id, value); }
        }

        public string Detalle
        {
            get { return _Detalle; }
            set { SetValue(ref _Detalle, value); }
        }
    }
}