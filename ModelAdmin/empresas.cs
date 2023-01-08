using System;
using System.ComponentModel.DataAnnotations;

namespace ModelAdmin
{

    public class empresas : baseViewModel
    {

        // Atributos de clase

        private int _Id;
        private string _Nit;
        private string _NombreEmpresa;
        private string _Direccion;
        private string _Telefono;
        private string _Celular;
        private string _Correo;
        private string _CuentaBancaria;
        private int _Decimales;
        private byte[] _Logo;
        private byte[] _Imagen;
        private string _HorarioAtencion;
        private DateTime _FechaOperacion;
        private string _UsuarioAutoriza;
        private string _Estado;
        private DateTime _FechaModificacion;
        private string _UsuarioModifica;

        // constructor

        public empresas()
        { }


        public empresas(int Id, string Nit, string NombreEmpresa, string Direccion, string Telefono, string Celular, string Correo, string CuentaBancaria, int Decimales, byte[] Logo, byte[] Imagen, string HorarioAtencion, DateTime FechaOperacion, string UsuarioAutoriza, string Estado, DateTime FechaModificacion, string UsuarioModifica)
        {
            this._Id = Id;
            this._Nit = Nit;
            this._NombreEmpresa = NombreEmpresa;
            this._Direccion = Direccion;
            this._Telefono = Telefono;
            this._Celular = Celular;
            this._Correo = Correo;
            this._CuentaBancaria = CuentaBancaria;
            this._Decimales = Decimales;
            this._Logo = Logo;
            this._Imagen = Imagen;
            this._HorarioAtencion = HorarioAtencion;
            this._FechaOperacion = FechaOperacion;
            this._UsuarioAutoriza = UsuarioAutoriza;
            this._Estado = Estado;
            this._FechaModificacion = FechaModificacion;
            this._UsuarioModifica = UsuarioModifica;
        }

        // Propiedades
        [Key]
        public int Id
        {
            get { return _Id; }
            set { SetValue(ref _Id, value); }
        }
        public string Nit
        {
            get { return _Nit; }
            set { SetValue(ref _Nit, value); }
        }
        public string NombreEmpresa
        {
            get { return _NombreEmpresa; }
            set { SetValue(ref _NombreEmpresa, value); }
        }
        public string Direccion
        {
            get { return _Direccion; }
            set { SetValue(ref _Direccion, value); }
        }
        public string Telefono
        {
            get { return _Telefono; }
            set { SetValue(ref _Telefono, value); }
        }
        public string Celular
        {
            get { return _Celular; }
            set { SetValue(ref _Celular, value); }
        }
        [EmailAddress(ErrorMessage = "El campo {0} debe de un correo valido")]
        public string Correo
        {
            get { return _Correo; }
            set { SetValue(ref _Correo, value); }
        }
        public string CuentaBancaria
        {
            get { return _CuentaBancaria; }
            set { SetValue(ref _CuentaBancaria, value); }
        }
        public int Decimales
        {
            get { return _Decimales; }
            set { SetValue(ref _Decimales, value); }
        }
        public byte[] Logo
        {
            get { return _Logo; }
            set { SetValue(ref _Logo, value); }
        }
        public byte[] Imagen
        {
            get { return _Imagen; }
            set { SetValue(ref _Imagen, value); }
        }
        public string HorarioAtencion
        {
            get { return _HorarioAtencion; }
            set { SetValue(ref _HorarioAtencion, value); }
        }
        public DateTime FechaOperacion
        {
            get { return _FechaOperacion; }
            set { SetValue(ref _FechaOperacion, value); }
        }
        public string UsuarioAutoriza
        {
            get { return _UsuarioAutoriza; }
            set { SetValue(ref _UsuarioAutoriza, value); }
        }
        public string Estado
        {
            get { return _Estado; }
            set { SetValue(ref _Estado, value); }
        }
        public DateTime FechaModificacion
        {
            get { return _FechaModificacion; }
            set { SetValue(ref _FechaModificacion, value); }
        }
        public string UsuarioModifica
        {
            get { return _UsuarioModifica; }
            set { SetValue(ref _UsuarioModifica, value); }
        }
    }
}
