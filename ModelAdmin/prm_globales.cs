using System;

namespace ModelAdmin
{
    public class prm_globales : baseViewModel
    {
        // Atributos de clase

        private int _Id;
        private string _Descripcion;
        private string _Valor;
        private DateTime _Fecha;

        // constructor

        public prm_globales()
        { }

        public prm_globales(int Id, string Descripcion, string Valor, DateTime Fecha)
        {
            this._Id = Id;
            this._Descripcion = Descripcion;
            this._Valor = Valor;
            this._Fecha = Fecha;
        }

        // Propiedades

        public int Id
        {
            get { return _Id; }
            set { SetValue(ref _Id, value); }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { SetValue(ref _Descripcion, value); }
        }

        public string Valor
        {
            get { return _Valor; }
            set { SetValue(ref _Valor, value); }
        }

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { SetValue(ref _Fecha, value); }
        }
    }
}