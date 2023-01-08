namespace ControlTotal
{
    #region Librerias

    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using NegociosCartera;
    using System;
    using System.Windows.Forms;

    #endregion Librerias

    public partial class ModuloXtraFactores : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Prpiedades

        private CadenaConexionMysql CadenaConexion;
        private negFactores NegFactores;
        private int count = 0;

        #endregion Prpiedades

        #region Constructor

        public ModuloXtraFactores(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegFactores = new negFactores(CadenaConexion);
            NegFactores.Event_ErrorTableNgConsultas += NegFactores_Event_ErrorTableNgConsultas;
            NegFactores.ErrorString_Event_factor += NegFactores_Event_ErrorStringFactor;
            NegFactores.OkString_Event_factor += NegFactores_Event_OkStringFactor;
            GrdFactor.DataSource = NegFactores.CnsDtConsulta("Factores");
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructor



        #region Disparadores

        private void NegFactores_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, " Factores", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void NegFactores_Event_OkStringFactor(string mensaje)
        {
            XtraMessageBox.Show(mensaje, " Factores", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void NegFactores_Event_ErrorStringFactor(string mensaje)
        {
            XtraMessageBox.Show(mensaje, " Factores", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Disparadores



        #region Eventos y Metodos

        private void BtnAdicionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnAdicionar.Enabled = false;
            XtraFactores Documento = new XtraFactores(CadenaConexion);
            Documento.ShowDialog();
            BtnAdicionar.Enabled = true;
        }

        private void BtnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvFactor.DataRowCount > 0)
            {
                BtnModificar.Enabled = false;
                int Id = Convert.ToInt32(GrvFactor.GetFocusedRowCellValue("Id").ToString());
                XtraFactores Documento = new XtraFactores(CadenaConexion, Id, "Modificar");
                Documento.ShowDialog();
                BtnModificar.Enabled = true;
            }
            else
            {
                XtraMessageBox.Show("No Ahy Factores para Modificar", " Factores", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void ModuloXtraFactores_Activated(object sender, EventArgs e)
        {
            if (count > 0)
            {
                GrdFactor.DataSource = NegFactores.CnsDtConsulta("Factores");
            }
            count += 1;
        }

        private void BtnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void BtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            BtnImprimir.Enabled = false;
            Utilidades utilidades = new Utilidades();
            utilidades.impirmir(GrdFactor, "LISTADO GENERAL DE FACTORES", CadenaConexion.Logeo.Logo);
            BtnImprimir.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void BtnExportarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(GrdFactor);
        }

        #endregion Eventos y Metodos
    }
}