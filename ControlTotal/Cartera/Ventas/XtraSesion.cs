namespace ControlTotal
{
    #region Librerias

    using Cartera;
    using Conexiones;
    using DevExpress.XtraBars;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System;
    using System.Data;
    using System.Windows.Forms;

    #endregion Librerias

    public partial class XtraSesion : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negSesion NegSesion;
        private string StrOperacion = string.Empty;
        private BindingSource Bs = new BindingSource();

        #endregion Propiedades

        #region Constructor

        public XtraSesion(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            StrOperacion = "Adicionar";
            CadenaConexion = cadenaConexion;
            NegSesion = new negSesion(CadenaConexion);
            BtnGuardar.Caption = StrOperacion;
            this.Text = StrOperacion + " Sesion";
            NegSesion.Event_ErrorTableNgConsultas += Consultas_Event_ErrorTableNgConsultas;
            NegSesion.ErrorString_Event_sesion += NegSesion_ErrorString_Event_sesion;
            NegSesion.OkString_Event_sesion += NegSesion_OkString_Event_sesion;
            Datos();
            Columnas();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        public XtraSesion(CadenaConexionMysql cadenaConexion, string strOperaciones, string IdSesion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            StrOperacion = strOperaciones;
            CadenaConexion = cadenaConexion;
            BtnGuardar.Caption = StrOperacion;
            this.Text = StrOperacion + " Sesion";
            NegSesion = new negSesion(CadenaConexion, IdSesion);
            NegSesion.Event_ErrorTableNgConsultas += Consultas_Event_ErrorTableNgConsultas;
            NegSesion.ErrorString_Event_sesion += NegSesion_ErrorString_Event_sesion;
            NegSesion.OkString_Event_sesion += NegSesion_OkString_Event_sesion;
            Datos();
            Columnas();
            CmbAdjudicacion.EditValue = NegSesion.EntSesion.IdTercero1;
            if (StrOperacion == "Aprobar" || StrOperacion == "Eliminar")
            {
                ReadOnly();
            }
            else
            {
                DtpFecha.ReadOnly = true;
                CmbAdjudicacion.ReadOnly = true;
            }
            TxtInmueble.EditValue = NegSesion.LstAdjSesion.Find(a => a.IdAdjudicacion == NegSesion.EntSesion.IdAdjudicacion).IdInmueble;
            TxtContrato.EditValue = NegSesion.LstAdjSesion.Find(a => a.IdAdjudicacion == NegSesion.EntSesion.IdAdjudicacion).Contrato;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructor

        #region Disparadores

        private void Consultas_Event_ErrorTableNgConsultas(string mensaje, DataTable dataTable)
        {
            BtnGuardar.Enabled = true;
            XtraMessageBox.Show(mensaje, " Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NegSesion_OkString_Event_sesion(string mensaje)
        {
            XtraMessageBox.Show(mensaje, " Sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NegSesion_ErrorString_Event_sesion(string mensaje)
        {
            BtnGuardar.Enabled = true;
            XtraMessageBox.Show(mensaje, " Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Disparadores

        #region Metodos

        private void BtnAddCliente_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnAddCliente.Enabled = false;
            XtraTerceros Documento = new XtraTerceros(CadenaConexion, 1);
            Documento.Show();
            Datos();
            BtnAddCliente.Enabled = true;
        }

        private void Datos()
        {
            DataTable Dt = NegSesion.CnsDtCombox("Clientes");

            CmbAdjudicacion.Properties.DataSource = NegSesion.LstAdjSesion;
            CmbAdjudicacion.Properties.DisplayMember = "TitularPrincipal";
            CmbAdjudicacion.Properties.ValueMember = "IdTercero1";

            CmbTitular2.Properties.DataSource = Dt;
            CmbTitular2.Properties.ValueMember = "IdTercero";
            CmbTitular2.Properties.DisplayMember = "Cliente";

            CmbTitular3.Properties.DataSource = Dt;
            CmbTitular3.Properties.ValueMember = "IdTercero";
            CmbTitular3.Properties.DisplayMember = "Cliente";

            CmbNuevoTitular.Properties.DataSource = Dt;
            CmbNuevoTitular.Properties.ValueMember = "IdTercero";
            CmbNuevoTitular.Properties.DisplayMember = "Cliente";

            CmbNuevoTitular2.Properties.DataSource = Dt;
            CmbNuevoTitular2.Properties.ValueMember = "IdTercero";
            CmbNuevoTitular2.Properties.DisplayMember = "Cliente";

            CmbNuevoTitular3.Properties.DataSource = Dt;
            CmbNuevoTitular3.Properties.ValueMember = "IdTercero";
            CmbNuevoTitular3.Properties.DisplayMember = "Cliente";
        }

        private void Columnas()
        {
            Bs.DataSource = NegSesion.EntSesion;
            DtpFecha.DataBindings.Add("EditValue", Bs, "Fecha", true, DataSourceUpdateMode.OnPropertyChanged);
            //CmbAdjudicacion.DataBindings.Add("EditValue", Bs, "IdTercero1", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbTitular2.DataBindings.Add("EditValue", Bs, "IdTercero2", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbTitular3.DataBindings.Add("EditValue", Bs, "IdTercero3", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtAdjudicaion.DataBindings.Add("EditValue", Bs, "IdAdjudicacion", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbNuevoTitular.DataBindings.Add("EditValue", Bs, "NuevoIdTercero1", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbNuevoTitular2.DataBindings.Add("EditValue", Bs, "NuevoIdTercero2", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbNuevoTitular3.DataBindings.Add("EditValue", Bs, "NuevoIdTercero3", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BtnGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Esta Seguro de " + StrOperacion + " Esta Sesion?", StrOperacion + " Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BtnGuardar.Enabled = false;
                SplashScreenManager.ShowForm(typeof(WaitForm1));

                switch (StrOperacion)
                {
                    case "Adicionar":
                        NegSesion.EntSesion.IdTercero1 = GrvAdjudicacion.GetFocusedRowCellValue("IdTercero1").ToString();
                        NegSesion.MtdAdicionar();
                        break;

                    case "Modificar":
                        NegSesion.MtdModificar();
                        break;

                    case "Eliminar":
                        NegSesion.MtdEliminar();
                        break;

                    case "Aprobar":
                        NegSesion.MtdAprobar();
                        break;

                    case "Desbloquear":

                        break;
                }
                if (SplashScreenManager.Default != null)
                    SplashScreenManager.CloseForm();
            }
        }

        private void ReadOnly()
        {
            DtpFecha.ReadOnly = true;
            CmbAdjudicacion.ReadOnly = true;
            CmbNuevoTitular.ReadOnly = true;
            CmbNuevoTitular2.ReadOnly = true;
            CmbNuevoTitular3.ReadOnly = true;
        }

        private void CmbAdjudicacion_EditValueChanged(object sender, EventArgs e)
        {
            TxtAdjudicaion.EditValue = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion");
            CmbTitular2.EditValue = GrvAdjudicacion.GetFocusedRowCellValue("IdTercero2");
            TxtInmueble.EditValue = GrvAdjudicacion.GetFocusedRowCellValue("IdInmueble");
            CmbTitular3.EditValue = GrvAdjudicacion.GetFocusedRowCellValue("IdTercero3");
            TxtContrato.EditValue = GrvAdjudicacion.GetFocusedRowCellValue("Contrato");
        }

        #endregion Metodos
    }
}