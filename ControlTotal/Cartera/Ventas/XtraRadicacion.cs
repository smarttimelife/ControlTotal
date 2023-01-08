using Conexiones;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using NegociosCartera;
using System;
using System.Data;
using System.Windows.Forms;

namespace ControlTotal
{
    public partial class XtraRadicacion : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negRadicacion NegRadicacion;
        private string StrOperacion = string.Empty;
        private string IdAdjudicacion = string.Empty;

        #endregion Propiedades

        #region Constructores

        public XtraRadicacion(CadenaConexionMysql cadenaConexion, string idAdjudicacion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            StrOperacion = "Adicionar";
            CadenaConexion = cadenaConexion;
            IdAdjudicacion = idAdjudicacion;
            NegRadicacion = new negRadicacion(cadenaConexion, idAdjudicacion);
            NegRadicacion.DataError_Event_Radica += NegRadicacion_DataError_Event_Radica;
            NegRadicacion.ErrorString_Evente_Radica += NegRadicacion_ErrorString_Evente_Radica;
            NegRadicacion.OkString_Evente_Radica += NegRadicacion_OkString_Evente_Radica;
            NegRadicacion.Inicio();
            CmbIdAdjudicacion.EditValue = IdAdjudicacion;
            TxtContrato.EditValue = NegRadicacion.EntviewAdjudicacion.Contrato;
            TxtTitular.EditValue = NegRadicacion.EntviewAdjudicacion.TitularPrincipal;
            TxtInmueble.EditValue = NegRadicacion.EntviewAdjudicacion.IdInmueble;
            TxtValor.EditValue = NegRadicacion.EntviewAdjudicacion.Valor;
            RpsAsesor.DataSource = NegRadicacion.CnsDtConsulta("Asesor");
            RpsAsesor.DisplayMember = "Asesor";
            RpsAsesor.ValueMember = "IdTercero";
            RpsCargo.DataSource = NegRadicacion.CnsDtConsulta("Cargo");
            RpsCargo.ValueMember = "IdCargo";
            RpsCargo.DisplayMember = "NombreCargo";
            CmbIdAdjudicacion.Properties.DataSource = NegRadicacion.CnsDtCombox("Radicado");

            CmbIdAdjudicacion.Properties.DisplayMember = "IdAdjudicacion";
            CmbIdAdjudicacion.Properties.ValueMember = "IdAdjudicacion";

            CmbIdAdjudicacion.ReadOnly = true;

            GrdAsesores.DataSource = NegRadicacion.dtComision;
            GrvAsesores.AddNewRow();
            GrvAsesores.SetFocusedRowCellValue("Com1", 0);
            GrvAsesores.SetFocusedRowCellValue("Com2", 0);

            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private DataTable DtAdj = new DataTable();

        public XtraRadicacion(CadenaConexionMysql cadenaConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));

            InitializeComponent();
            StrOperacion = "Adicionar";
            CadenaConexion = cadenaConexion;
            NegRadicacion = new negRadicacion(cadenaConexion);

            NegRadicacion.DataError_Event_Radica += NegRadicacion_DataError_Event_Radica;
            NegRadicacion.ErrorString_Evente_Radica += NegRadicacion_ErrorString_Evente_Radica;
            NegRadicacion.OkString_Evente_Radica += NegRadicacion_OkString_Evente_Radica;
            NegRadicacion.Inicio();
            RpsAsesor.DataSource = NegRadicacion.CnsDtConsulta("Asesor");
            RpsAsesor.DisplayMember = "Asesor";
            RpsAsesor.ValueMember = "IdTercero";
            RpsCargo.DataSource = NegRadicacion.CnsDtConsulta("Cargo");
            RpsCargo.ValueMember = "IdCargo";
            RpsCargo.DisplayMember = "NombreCargo";
            DtAdj = NegRadicacion.CnsDtCombox("Radicado");
            CmbIdAdjudicacion.Properties.DataSource = DtAdj;
            CmbIdAdjudicacion.Properties.DisplayMember = "IdAdjudicacion";
            CmbIdAdjudicacion.Properties.ValueMember = "IdAdjudicacion";
            GrdAsesores.DataSource = NegRadicacion.dtComision;
            GrvAsesores.AddNewRow();
            GrvAsesores.SetFocusedRowCellValue("Com1", 0);
            GrvAsesores.SetFocusedRowCellValue("Com2", 0);

            if (DtAdj.Rows.Count == 0)
            {
                GrvAsesores.OptionsBehavior.ReadOnly = true;
                XtraMessageBox.Show("No Ahy Negocios Por Radicar", "Radicacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnGuardar.Enabled = false;
                Root.Enabled = false;
            }

            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        public XtraRadicacion(CadenaConexionMysql cadenaConexion, string idAdjudicacion, string strOperacion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            StrOperacion = strOperacion;
            CadenaConexion = cadenaConexion;
            IdAdjudicacion = idAdjudicacion;
            NegRadicacion = new negRadicacion(cadenaConexion, idAdjudicacion);
            NegRadicacion.DataError_Event_Radica += NegRadicacion_DataError_Event_Radica;
            NegRadicacion.ErrorString_Evente_Radica += NegRadicacion_ErrorString_Evente_Radica;
            NegRadicacion.OkString_Evente_Radica += NegRadicacion_OkString_Evente_Radica;
            NegRadicacion.Inicio(idAdjudicacion);

            RpsAsesor.DataSource = NegRadicacion.CnsDtConsulta("Asesor");
            RpsAsesor.DisplayMember = "Asesor";
            RpsAsesor.ValueMember = "IdTercero";

            RpsCargo.DataSource = NegRadicacion.CnsDtConsulta("CargosTodos");
            RpsCargo.ValueMember = "IdCargo";
            RpsCargo.DisplayMember = "NombreCargo";

            CmbIdAdjudicacion.Properties.DataSource = NegRadicacion.CnsDtCombox("ModRadicado");
            CmbIdAdjudicacion.Properties.DisplayMember = "IdAdjudicacion";
            CmbIdAdjudicacion.Properties.ValueMember = "IdAdjudicacion";
            CmbIdAdjudicacion.Text = IdAdjudicacion;
            TxtContrato.EditValue = NegRadicacion.EntviewAdjudicacion.Contrato;
            TxtTitular.EditValue = NegRadicacion.EntviewAdjudicacion.TitularPrincipal;
            TxtInmueble.EditValue = NegRadicacion.EntviewAdjudicacion.IdInmueble;
            TxtValor.EditValue = NegRadicacion.EntviewAdjudicacion.Valor;

            GrdAsesores.DataSource = NegRadicacion.dtComision;
            CmbIdAdjudicacion.ReadOnly = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructores

        #region Disparadores

        private void NegRadicacion_OkString_Evente_Radica(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Radicacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GrdAsesores.Enabled = false;
            BtnImprimir.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegRadicacion_ErrorString_Evente_Radica(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Radicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnGuardar.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegRadicacion_DataError_Event_Radica(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Radicacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion Disparadores

        #region Metodos

        private void BtnSalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void BtnGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Esta Seguro de " + StrOperacion + " Radicacion ?", StrOperacion + " Radicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                BtnGuardar.Enabled = false;
                switch (StrOperacion)
                {
                    case "Adicionar":
                        NegRadicacion.MtdAdicionar();
                        break;

                    case "Modificar":
                        NegRadicacion.MtdModificar();
                        break;

                    case "Eliminar":

                        break;

                    case "Aprobar":

                        break;

                    case "Desaprobar":

                        break;
                }
            }
        }

        private void BtnImprimir_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraRptComision comision = new XtraRptComision(CadenaConexion, IdAdjudicacion);
            comision.Show();
        }

        private void CmbIdAdjudicacion_EditValueChanged(object sender, System.EventArgs e)
        {
            TxtInmueble.EditValue = GrvAdjudicacion.GetFocusedRowCellValue("IdInmueble");
            TxtValor.EditValue = GrvAdjudicacion.GetFocusedRowCellValue("Valor");
            TxtTitular.EditValue = GrvAdjudicacion.GetFocusedRowCellValue("TitularPrincipal");
            TxtContrato.EditValue = GrvAdjudicacion.GetFocusedRowCellValue("Contrato");
            if (GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion") != null)
            {
                NegRadicacion.IdAdjudicacion = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
            }
        }

        private void GrdAsesores_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    GrvAsesores.DeleteRow(GrvAsesores.FocusedRowHandle);
                    if (GrvAsesores.DataRowCount == 0)
                    {
                        GrvAsesores.AddNewRow();
                        GrvAsesores.SetFocusedRowCellValue("Com1", 0);
                        GrvAsesores.SetFocusedRowCellValue("Com2", 0);
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    string strDato0, strDato1;
                    decimal decCom1 = 0, decCom2 = 0;

                    if (GrvAsesores.FocusedRowHandle == GrvAsesores.RowCount - 1)
                    {
                        GrvAsesores.CloseEditor();
                        strDato0 = GrvAsesores.GetRowCellValue(GrvAsesores.FocusedRowHandle, GrvAsesores.Columns[0]).ToString();
                        strDato1 = GrvAsesores.GetRowCellValue(GrvAsesores.FocusedRowHandle, GrvAsesores.Columns[1]).ToString();
                        decCom1 = Convert.ToDecimal(GrvAsesores.GetRowCellValue(GrvAsesores.FocusedRowHandle, GrvAsesores.Columns[2]).ToString());
                        decCom2 = Convert.ToDecimal(GrvAsesores.GetRowCellValue(GrvAsesores.FocusedRowHandle, GrvAsesores.Columns[3]).ToString());

                        if (strDato0 != string.Empty && strDato1 != string.Empty && decCom1 > 0 && decCom2 > 0)
                        {
                            GrvAsesores.AddNewRow();
                            GrvAsesores.SetFocusedRowCellValue("Com1", 0);
                            GrvAsesores.SetFocusedRowCellValue("Com2", 0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, " Logeo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Metodos

        private void XtraRadicacion_Load(object sender, EventArgs e)
        {
        }
    }
}