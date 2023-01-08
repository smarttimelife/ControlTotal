namespace ModelAdmin
{
    public class tipdocumento : baseViewModel
    {
        // Atributos de clase

        private int _Id;
        private string _TipoDocumento;

        // constructor

        public tipdocumento()
        { }

        public tipdocumento(int Id, string TipoDocumento)
        {
            this._Id = Id;
            this._TipoDocumento = TipoDocumento;
        }

        // Propiedades

        public int Id
        {
            get { return _Id; }
            set { SetValue(ref _Id, value); }
        }

        public string TipoDocumento
        {
            get { return _TipoDocumento; }
            set { SetValue(ref _TipoDocumento, value); }
        }
    }
}