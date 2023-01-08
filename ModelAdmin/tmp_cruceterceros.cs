namespace ModelAdmin
{
    public class tmp_cruceterceros : baseViewModel
    {
        // Atributos de clase

        private int _Id;
        private string _IdTercero;
        private string _proyecto;
        private string _software;

        // constructor

        public tmp_cruceterceros()
        { }

        public tmp_cruceterceros(int Id, string IdTercero, string proyecto, string software)
        {
            this._Id = Id;
            this._IdTercero = IdTercero;
            this._proyecto = proyecto;
            this._software = software;
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

        public string proyecto
        {
            get { return _proyecto; }
            set { SetValue(ref _proyecto, value); }
        }

        public string software
        {
            get { return _software; }
            set { SetValue(ref _software, value); }
        }
    }
}