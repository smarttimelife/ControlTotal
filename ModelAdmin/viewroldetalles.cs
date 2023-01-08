using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelAdmin
{
    [Table("viewroldetalles")]
    public class viewroldetalles : baseViewModel
    {

        // Atributos de clase

        private int _Id;
        private string _NombreFormulario;
        private string _Modulo;
        private int _IdSoftware;
        private int _IdRol;
        private bool _Ver;
        private bool _Adicionar;
        private bool _Modificar;
        private bool _Eliminar;
        private bool _Cerrar;
        private bool _Imprimir;
        private bool _Aprobar;
        private bool _Desaprobar;

        // constructor

        public viewroldetalles()
        { }


        public viewroldetalles(int Id, string NombreFormulario, string Modulo, int IdSoftware, int IdRol, bool Ver, bool Adicionar, bool Modificar, bool Eliminar, bool Cerrar, bool Imprimir, bool Aprobar, bool Desaprobar)
        {
            this._Id = Id;
            this._NombreFormulario = NombreFormulario;
            this._Modulo = Modulo;
            this._IdSoftware = IdSoftware;
            this._IdRol = IdRol;
            this._Ver = Ver;
            this._Adicionar = Adicionar;
            this._Modificar = Modificar;
            this._Eliminar = Eliminar;
            this._Cerrar = Cerrar;
            this._Imprimir = Imprimir;
            this._Aprobar = Aprobar;
            this._Desaprobar = Desaprobar;
        }

        // Propiedades
        [Key]
        public int Id
        {
            get { return _Id; }
            set { SetValue(ref _Id, value); }
        }
        public string NombreFormulario
        {
            get { return _NombreFormulario; }
            set { SetValue(ref _NombreFormulario, value); }
        }
        public string Modulo
        {
            get { return _Modulo; }
            set { SetValue(ref _Modulo, value); }
        }
        public int IdSoftware
        {
            get { return _IdSoftware; }
            set { SetValue(ref _IdSoftware, value); }
        }
        public int IdRol
        {
            get { return _IdRol; }
            set { SetValue(ref _IdRol, value); }
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
    }
}
