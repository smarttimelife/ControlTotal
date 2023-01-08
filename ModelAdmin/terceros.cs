using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelAdmin
{
    [Table("terceros")]
    public class terceros : baseViewModel
    {
        // Atributos de clase

        private int _Id;
        private string _IdTercero;
        private int _TipoPersona;
        private int _IdTipoDocumento;
        private string _Nombres;
        private string _Apellidos;
        private DateTime _FechaNacimiento;
        private string _Direccion;
        private string _Barrio;
        private string _Ciudad;
        private string _Departamento;
        private string _Telefono1;
        private string _Telefono2;
        private string _Celular;
        private string _CorreoElectronico;
        private string _PaginaWeb;
        private string _Contacto;
        private string _NombreCompleto;
        private int _IdTransaccion;

        // constructor

        public terceros()
        { }

        public terceros(int Id, string IdTercero, int TipoPersona, int IdTipoDocumento, string Nombres, string Apellidos, DateTime FechaNacimiento, string Direccion, string Barrio, string Ciudad, string Departamento, string Telefono1, string Telefono2, string Celular, string CorreoElectronico, string PaginaWeb, string Contacto, string NombreCompleto, int IdTransaccion)
        {
            this._Id = Id;
            this._IdTercero = IdTercero;
            this._TipoPersona = TipoPersona;
            this._IdTipoDocumento = IdTipoDocumento;
            this._Nombres = Nombres;
            this._Apellidos = Apellidos;
            this._FechaNacimiento = FechaNacimiento;
            this._Direccion = Direccion;
            this._Barrio = Barrio;
            this._Ciudad = Ciudad;
            this._Departamento = Departamento;
            this._Telefono1 = Telefono1;
            this._Telefono2 = Telefono2;
            this._Celular = Celular;
            this._CorreoElectronico = CorreoElectronico;
            this._PaginaWeb = PaginaWeb;
            this._Contacto = Contacto;
            this._NombreCompleto = NombreCompleto;
            this._IdTransaccion = IdTransaccion;
        }

        // Propiedades

        public int Id
        {
            get { return _Id; }
            set { SetValue(ref _Id, value); }
        }

        [Key]
        public string IdTercero
        {
            get { return _IdTercero; }
            set { SetValue(ref _IdTercero, value); }
        }

        public int TipoPersona
        {
            get { return _TipoPersona; }
            set { SetValue(ref _TipoPersona, value); }
        }

        public int IdTipoDocumento
        {
            get { return _IdTipoDocumento; }
            set { SetValue(ref _IdTipoDocumento, value); }
        }

        public string Nombres
        {
            get { return _Nombres; }
            set { SetValue(ref _Nombres, value); }
        }

        public string Apellidos
        {
            get { return _Apellidos; }
            set { SetValue(ref _Apellidos, value); }
        }

        public DateTime FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { SetValue(ref _FechaNacimiento, value); }
        }

        public string Direccion
        {
            get { return _Direccion; }
            set { SetValue(ref _Direccion, value); }
        }

        public string Barrio
        {
            get { return _Barrio; }
            set { SetValue(ref _Barrio, value); }
        }

        public string Ciudad
        {
            get { return _Ciudad; }
            set { SetValue(ref _Ciudad, value); }
        }

        public string Departamento
        {
            get { return _Departamento; }
            set { SetValue(ref _Departamento, value); }
        }

        public string Telefono1
        {
            get { return _Telefono1; }
            set { SetValue(ref _Telefono1, value); }
        }

        public string Telefono2
        {
            get { return _Telefono2; }
            set { SetValue(ref _Telefono2, value); }
        }

        public string Celular
        {
            get { return _Celular; }
            set { SetValue(ref _Celular, value); }
        }

        public string CorreoElectronico
        {
            get { return _CorreoElectronico; }
            set { SetValue(ref _CorreoElectronico, value); }
        }

        public string PaginaWeb
        {
            get { return _PaginaWeb; }
            set { SetValue(ref _PaginaWeb, value); }
        }

        public string Contacto
        {
            get { return _Contacto; }
            set { SetValue(ref _Contacto, value); }
        }

        public string NombreCompleto
        {
            get { return _NombreCompleto; }
            set { SetValue(ref _NombreCompleto, value); }
        }

        public int IdTransaccion
        {
            get { return _IdTransaccion; }
            set { SetValue(ref _IdTransaccion, value); }
        }
    }
}