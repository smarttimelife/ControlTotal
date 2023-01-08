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

    public partial class XtraModuloOficina : DevExpress.XtraEditors.XtraForm
    {
        #region Prpiedades

        private CadenaConexionMysql CadenaConexion;
        private negFactores NegFactores;

        #endregion Prpiedades

        #region Constructor

        public XtraModuloOficina(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegFactores = new negFactores(CadenaConexion);
            NegFactores.Event_ErrorTableNgConsultas += NegFactores_Event_ErrorTableNgConsultas;
            NegFactores.ErrorString_Event_factor += NegFactores_Event_ErrorStringFactor;
            NegFactores.OkString_Event_factor += NegFactores_Event_OkStringFactor;
            GrdOficina.DataSource = NegFactores.CnsDtConsulta("Oficina");
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructor



        #region Disparadores

        private void NegFactores_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, " Oficina", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void NegFactores_Event_OkStringFactor(string mensaje)
        {
            XtraMessageBox.Show(mensaje, " Oficina", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void NegFactores_Event_ErrorStringFactor(string mensaje)
        {
            XtraMessageBox.Show(mensaje, " Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Disparadores



        #region Eventos y Metodos

        private void BtnAdicionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnAdicionar.Enabled = false;
            XtraOficina Documento = new XtraOficina(CadenaConexion);
            Documento.ShowDialog();
            BtnAdicionar.Enabled = true;
            GrdOficina.DataSource = NegFactores.CnsDtConsulta("Oficina");
        }

        private void BtnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvFactor.DataRowCount > 0)
            {
                BtnModificar.Enabled = false;
                int Id = Convert.ToInt32(GrvFactor.GetFocusedRowCellValue("Id").ToString());
                XtraOficina Documento = new XtraOficina(CadenaConexion, Id, "Modificar");
                Documento.ShowDialog();
                BtnModificar.Enabled = true;
                GrdOficina.DataSource = NegFactores.CnsDtConsulta("Oficina");
            }
            else
            {
                XtraMessageBox.Show("No Ahy Factores para Modificar", " Factores", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        #endregion Eventos y Metodos
    }
}