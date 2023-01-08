using System;
using System.ComponentModel.DataAnnotations;

namespace ModelAdmin
{

    public class roles : baseViewModel
    {
        // Atributos de clase

        private int _Id;
        private string _NombreRol;
        private DateTime _FechaOperacion;
        private string _UsuarioAutoriza;
        private string _Estado;

        // constructor

        public roles()
        { }

        public roles(int Id, string NombreRol, DateTime FechaOperacion, string UsuarioAutoriza, string Estado)
        {
            this._Id = Id;
            this._NombreRol = NombreRol;
            this._FechaOperacion = FechaOperacion;
            this._UsuarioAutoriza = UsuarioAutoriza;
            this._Estado = Estado;
        }

        // Propiedades
        [Key]
        public int Id
        {
            get { return _Id; }
            set { SetValue(ref _Id, value); }
        }

        public string NombreRol
        {
            get { return _NombreRol; }
            set { SetValue(ref _NombreRol, value); }
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
    }
}