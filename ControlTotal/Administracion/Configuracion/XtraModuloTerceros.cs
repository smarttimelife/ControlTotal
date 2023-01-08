namespace ControlTotal
{
    #region Librerias

    using Administracion.NegociosAdmin;
    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System.Windows.Forms;

    #endregion Librerias

    public partial class XtraModuloTerceros : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private string StrIdTercero = string.Empty;
        private string StrTipo = string.Empty;
        private string StrModulo = string.Empty;
        private negTerceros Terceros;
        private int TipoCliente = 0;

        #endregion Propiedades

        #region Constructor

        public XtraModuloTerceros(CadenaConexionMysql cadenaConexion, int tipocliente, string strModulo)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            TipoCliente = tipocliente;
            CadenaConexion = cadenaConexion;
            StrModulo = strModulo;
            Terceros = new negTerceros(cadenaConexion, tipocliente);
            Terceros.Event_ErrorTableNgConsultas += Terceros_Event_ErrorTableNgConsultas;
            switch (tipocliente)
            {
                case 1:
                    StrTipo = "Cliente";

                    break;

                case 2:
                    StrTipo = "Provedores";
                    break;

                case 3:
                    StrTipo = "Empleados";
                    break;

                case 4:
                    StrTipo = "Asesor";
                    break;

                default:
                    break;
            }

            this.Text = StrTipo;
            GrdTerceros.DataSource = Terceros.CnsDtConsulta(StrTipo);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructor

        #region Disparadores

        private void Terceros_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Modulo de" + StrTipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Disparadores

        #region Metodos

        private void BtnAdicionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnAdicionar.Enabled = false;
            XtraTerceros Documento = new XtraTerceros(CadenaConexion, TipoCliente);
            Documento.ShowDialog();
            BtnAdicionar.Enabled = true;
            GrdTerceros.DataSource = Terceros.CnsDtConsulta(StrTipo);
        }

        private void BtnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnEliminar.Enabled = false;
            XtraTerceros Documento = new XtraTerceros(CadenaConexion, TipoCliente, "Eliminar", StrIdTercero);
            Documento.ShowDialog();
            BtnEliminar.Enabled = true;
            GrdTerceros.DataSource = Terceros.CnsDtConsulta(StrTipo);
        }

        private void BtnExportarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(GrdTerceros);
        }

        private void BtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            BtnImprimir.Enabled = false;
            Utilidades utilidades = new Utilidades();
            utilidades.impirmir(GrdTerceros, "LISTADO GENERAL DE " + StrTipo.ToUpper(), CadenaConexion.Logeo.Logo);
            BtnImprimir.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void BtnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnModificar.Enabled = false;
            XtraTerceros Documento = new XtraTerceros(CadenaConexion, TipoCliente, "Modificar", StrIdTercero);
            Documento.ShowDialog();
            BtnModificar.Enabled = true;
            GrdTerceros.DataSource = Terceros.CnsDtConsulta(StrTipo);
        }

        private void BtnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void GrvTerceros_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (GrvTerceros.DataRowCount > 0)
            {
                if(GrvTerceros.GetFocusedRowCellValue("IdTercero")!=null)
                StrIdTercero = GrvTerceros.GetFocusedRowCellValue("IdTercero").ToString();
            }
        }      

        private void XtraModuloTerceros_Load(object sender, System.EventArgs e)
        {
            BtnAdicionar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Adicionar;
            BtnModificar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Modificar;
            BtnEliminar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Eliminar;
            BtnImprimir.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Imprimir;
        }

        #endregion Metodos
    }
}