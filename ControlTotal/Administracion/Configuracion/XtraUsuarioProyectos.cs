namespace ControlTotal
{
    #region Librerias

    using Administracion.NegociosAdmin;
    using Conexiones;
    using DevExpress.XtraEditors;
    using System;
    using System.Data;
    using System.Windows.Forms;

    //JAVIER ENRIQUE VILLALBA ESPINSOSA
    //10 DE ABRIL DEL 2020

    #endregion Librerias

    public partial class XtraUsuarioProyectos : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negUsuario_Proyecto NegUsuario_Proyecto;
        private BindingSource BsUsuario = new BindingSource();
        private int IdUsuario = 0;

        #endregion Propiedades

        #region Constructores

        public XtraUsuarioProyectos(CadenaConexionMysql cadenaConexion, int idUsuario)
        {
            InitializeComponent();
            IdUsuario = idUsuario;
            CadenaConexion = cadenaConexion;
            NegUsuario_Proyecto = new negUsuario_Proyecto(CadenaConexion, IdUsuario);
            NegUsuario_Proyecto.ErrorString_Event__UsrProye += NegUsuario_Proyecto_ErrorString_Event__UsrProye;
            NegUsuario_Proyecto.OkString_Event__UsrProye += NegUsuario_Proyecto_OkString_Event__UsrProye;
            NegUsuario_Proyecto.Event_ErrorTableNgConsultas += NegUsuario_Proyecto_Event_ErrorTableNgConsultas;
            TxtIdUsuario.EditValue = NegUsuario_Proyecto.EntUsuarios.IdUsuario;
            TxtNombreUsuario.EditValue = NegUsuario_Proyecto.EntUsuarios.NombreUsuario;
            BsUsuario.DataSource = NegUsuario_Proyecto.Entusuarios_Proyectos;
            CmbProyectos.DataBindings.Add("EditValue", BsUsuario, "IdProyecto", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbSoftware.DataBindings.Add("EditValue", BsUsuario, "IdSoftware", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        #endregion Constructores

        #region Disparadores

        private void NegUsuario_Proyecto_OkString_Event__UsrProye(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Usuario Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void NegUsuario_Proyecto_ErrorString_Event__UsrProye(string mensaje)
        {
            XtraMessageBox.Show("Se Presento El Sgte Error " + mensaje, "Usuario Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NegUsuario_Proyecto_Event_ErrorTableNgConsultas(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show("Se Presento El Sgte Error " + mensaje + " Se Cerrara esta Ventana", "Usuario Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }

        #endregion Disparadores

        #region Metodos

        public void Inicio()
        {
            CmbProyectos.Properties.DataSource = NegUsuario_Proyecto.CnsDatos_Proyectos();
            CmbProyectos.Properties.DisplayMember = "NombreProyecto";
            CmbProyectos.Properties.ValueMember = "Id";

            CmbSoftware.Properties.DataSource = NegUsuario_Proyecto.CnsSoftware();
            CmbSoftware.Properties.DisplayMember = "NombreSoftware";
            CmbSoftware.Properties.ValueMember = "Id";

            RpsProyecto.DataSource = NegUsuario_Proyecto.CnsDatos_Proyectos();
            RpsProyecto.DisplayMember = "NombreProyecto";
            RpsProyecto.ValueMember = "Id";

            RpsSoftware.DataSource = NegUsuario_Proyecto.CnsSoftware();
            RpsSoftware.DisplayMember = "NombreSoftware";
            RpsSoftware.ValueMember = "Id";
        }

        private void XtraUsuarioProyectos_Load(object sender, EventArgs e)
        {
            Inicio();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (GrvUsuarioProyecto.DataRowCount == 0)
            {
                XtraMessageBox.Show("No Ahy Registros Para Eliminar", "Usuario Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int Id = Convert.ToInt32(GrvUsuarioProyecto.GetFocusedRowCellValue("Id").ToString());
                BtnEliminar.Enabled = false;
                if (XtraMessageBox.Show("¿Esta Seguro de Eliminar Este proyecto?", " Usuario_Proyectos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Cursor = Cursors.AppStarting;
                    NegUsuario_Proyecto.MtdEliminar(Id);
                }
                this.Cursor = Cursors.Default;
                BtnEliminar.Enabled = true;
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            BtnAdicionar.Enabled = false;
            if (XtraMessageBox.Show("¿Esta Seguro de Adicionar Este proyecto?", " Usuario_Proyectos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Cursor = Cursors.AppStarting;
                NegUsuario_Proyecto.MtdAdicionar();
            }
            this.Cursor = Cursors.Default;
            BtnAdicionar.Enabled = true;
        }

        private void XtraUsuarioProyectos_Activated(object sender, EventArgs e)
        {
            GrdUsuarioProyecto.DataSource = NegUsuario_Proyecto.CnsDatos_Usuarios_Proyectos(IdUsuario);
        }

        #endregion Metodos
    }
}