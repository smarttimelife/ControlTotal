using System;

namespace ModelAdmin
{
    public class transacciones : baseViewModel
    {
        // Atributos de clase

        private int _Id;
        private string _Accion;
        private DateTime _Fecha;
        private string _Modulo;
        private string _Registro;
        private string _Usuario;

        // constructor

        public transacciones()
        { }

        public transacciones(int Id, string Accion, DateTime Fecha, string Modulo, string Registro, string Usuario)
        {
            this._Id = Id;
            this._Accion = Accion;
            this._Fecha = Fecha;
            this._Modulo = Modulo;
            this._Registro = Registro;
            this._Usuario = Usuario;
        }

        // Propiedades

        public int Id
        {
            get { return _Id; }
            set { SetValue(ref _Id, value); }
        }

        public string Accion
        {
            get { return _Accion; }
            set { SetValue(ref _Accion, value); }
        }

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { SetValue(ref _Fecha, value); }
        }

        public string Modulo
        {
            get { return _Modulo; }
            set { SetValue(ref _Modulo, value); }
        }

        public string Registro
        {
            get { return _Registro; }
            set { SetValue(ref _Registro, value); }
        }

        public string Usuario
        {
            get { return _Usuario; }
            set { SetValue(ref _Usuario, value); }
        }
    }
}