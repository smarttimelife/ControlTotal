using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;

namespace ModelAdmin
{

    public class roldetalles : baseViewModel
    {
        // Atributos de clase

        private int _Id;
        private int _IdRol;
        private string _IdFormulario;
        private bool _Ver;
        private bool _Adicionar;
        private bool _Modificar;
        private bool _Eliminar;
        private bool _Cerrar;
        private bool _Imprimir;
        private bool _Aprobar;
        private bool _Desaprobar;
        private DateTime _FechaOperacion;
        private string _UsuarioAutoriza;

        // constructor

        public roldetalles()
        { }

        public roldetalles(int Id, int IdRol, string IdFormulario, bool Ver, bool Adicionar, bool Modificar, bool Eliminar, bool Cerrar, bool Imprimir, bool Aprobar, bool Desaprobar, DateTime FechaOperacion, string UsuarioAutoriza)
        {
            this._Id = Id;
            this._IdRol = IdRol;
            this._IdFormulario = IdFormulario;
            this._Ver = Ver;
            this._Adicionar = Adicionar;
            this._Modificar = Modificar;
            this._Eliminar = Eliminar;
            this._Cerrar = Cerrar;
            this._Imprimir = Imprimir;
            this._Aprobar = Aprobar;
            this._Desaprobar = Desaprobar;
            this._FechaOperacion = FechaOperacion;
            this._UsuarioAutoriza = UsuarioAutoriza;
        }

        // Propiedades
        [Key]
        public int Id
        {
            get { return _Id; }
            set { SetValue(ref _Id, value); }
        }

        public int IdRol
        {
            get { return _IdRol; }
            set { SetValue(ref _IdRol, value); }
        }

        public string IdFormulario
        {
            get { return _IdFormulario; }
            set { SetValue(ref _IdFormulario, value); }
        }

        public bool Ver
        {
            get { return _Ver; }
            set { SetValue(ref _Ver, value); }
        }

        public bool Adicionar
        {
            get { return _Adicionar; }
            set { SetValue(ref _Adicionar, value); }
        }

        public bool Modificar
        {
            get { return _Modificar; }
            set { SetValue(ref _Modificar, value); }
        }

        public bool Eliminar
        {
            get { return _Eliminar; }
            set { SetValue(ref _Eliminar, value); }
        }

        public bool Cerrar
        {
            get { return _Cerrar; }
            set { SetValue(ref _Cerrar, value); }
        }

        public bool Imprimir
        {
            get { return _Imprimir; }
            set { SetValue(ref _Imprimir, value); }
        }

        public bool Aprobar
        {
            get { return _Aprobar; }
            set { SetValue(ref _Aprobar, value); }
        }

        public bool Desaprobar
        {
            get { return _Desaprobar; }
            set { SetValue(ref _Desaprobar, value); }
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
    }
}