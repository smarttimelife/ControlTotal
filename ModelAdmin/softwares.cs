namespace ModelAdmin
{
    public class softwares : baseViewModel
    {
        // Atributos de clase

        private int _Id;
        private string _NombreSoftware;

        // constructor

        public softwares()
        { }

        public softwares(int Id, string NombreSoftware)
        {
            this._Id = Id;
            this._NombreSoftware = NombreSoftware;
        }

        // Propiedades

        public int Id
        {
            get { return _Id; }
            set { SetValue(ref _Id, value); }
        }

        public string NombreSoftware
        {
            get { return _NombreSoftware; }
            set { SetValue(ref _NombreSoftware, value); }
        }
    }
}