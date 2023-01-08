using System;

namespace ModelAdmin
{
    public class evaluacioncontratista : baseViewModel
    {
        // Atributos de clase

        private int _Id;
        private DateTime _Fecha;
        private string _IdTercero;
        private int _NumOrden;
        private int _CentroCosto;
        private int _SubCentro;
        private int _OportunidadEntrega;
        private int _Reclamos;
        private int _CalidadServicio;
        private int _Garantia;
        private int _CumplimientoLegal;
        private int _Adaptaciones;
        private int _UsoRecurso;
        private bool _Materiales;
        private bool _Herramientas;
        private bool _Equipo;
        private bool _Limpieza;
        private bool _DanosTerceros;
        private bool _Financiero;
        private string _Pendientes;
        private string _Usuario;

        // constructor

        public evaluacioncontratista()
        { }

        public evaluacioncontratista(int Id, DateTime Fecha, string IdTercero, int NumOrden, int CentroCosto, int SubCentro, int OportunidadEntrega, int Reclamos, int CalidadServicio, int Garantia, int CumplimientoLegal, int Adaptaciones, int UsoRecurso, bool Materiales, bool Herramientas, bool Equipo, bool Limpieza, bool DanosTerceros, bool Financiero, string Pendientes, string Usuario)
        {
            this._Id = Id;
            this._Fecha = Fecha;
            this._IdTercero = IdTercero;
            this._NumOrden = NumOrden;
            this._CentroCosto = CentroCosto;
            this._SubCentro = SubCentro;
            this._OportunidadEntrega = OportunidadEntrega;
            this._Reclamos = Reclamos;
            this._CalidadServicio = CalidadServicio;
            this._Garantia = Garantia;
            this._CumplimientoLegal = CumplimientoLegal;
            this._Adaptaciones = Adaptaciones;
            this._UsoRecurso = UsoRecurso;
            this._Materiales = Materiales;
            this._Herramientas = Herramientas;
            this._Equipo = Equipo;
            this._Limpieza = Limpieza;
            this._DanosTerceros = DanosTerceros;
            this._Financiero = Financiero;
            this._Pendientes = Pendientes;
            this._Usuario = Usuario;
        }

        // Propiedades

        public int Id
        {
            get { return _Id; }
            set { SetValue(ref _Id, value); }
        }

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { SetValue(ref _Fecha, value); }
        }

        public string IdTercero
        {
            get { return _IdTercero; }
            set { SetValue(ref _IdTercero, value); }
        }

        public int NumOrden
        {
            get { return _NumOrden; }
            set { SetValue(ref _NumOrden, value); }
        }

        public int CentroCosto
        {
            get { return _CentroCosto; }
            set { SetValue(ref _CentroCosto, value); }
        }

        public int SubCentro
        {
            get { return _SubCentro; }
            set { SetValue(ref _SubCentro, value); }
        }

        public int OportunidadEntrega
        {
            get { return _OportunidadEntrega; }
            set { SetValue(ref _OportunidadEntrega, value); }
        }

        public int Reclamos
        {
            get { return _Reclamos; }
            set { SetValue(ref _Reclamos, value); }
        }

        public int CalidadServicio
        {
            get { return _CalidadServicio; }
            set { SetValue(ref _CalidadServicio, value); }
        }

        public int Garantia
        {
            get { return _Garantia; }
            set { SetValue(ref _Garantia, value); }
        }

        public int CumplimientoLegal
        {
            get { return _CumplimientoLegal; }
            set { SetValue(ref _CumplimientoLegal, value); }
        }

        public int Adaptaciones
        {
            get { return _Adaptaciones; }
            set { SetValue(ref _Adaptaciones, value); }
        }

        public int UsoRecurso
        {
            get { return _UsoRecurso; }
            set { SetValue(ref _UsoRecurso, value); }
        }

        public bool Materiales
        {
            get { return _Materiales; }
            set { SetValue(ref _Materiales, value); }
        }

        public bool Herramientas
        {
            get { return _Herramientas; }
            set { SetValue(ref _Herramientas, value); }
        }

        public bool Equipo
        {
            get { return _Equipo; }
            set { SetValue(ref _Equipo, value); }
        }

        public bool Limpieza
        {
            get { return _Limpieza; }
            set { SetValue(ref _Limpieza, value); }
        }

        public bool DanosTerceros
        {
            get { return _DanosTerceros; }
            set { SetValue(ref _DanosTerceros, value); }
        }

        public bool Financiero
        {
            get { return _Financiero; }
            set { SetValue(ref _Financiero, value); }
        }

        public string Pendientes
        {
            get { return _Pendientes; }
            set { SetValue(ref _Pendientes, value); }
        }

        public string Usuario
        {
            get { return _Usuario; }
            set { SetValue(ref _Usuario, value); }
        }
    }
}