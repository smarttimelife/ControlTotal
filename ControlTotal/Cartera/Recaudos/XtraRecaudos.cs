namespace ControlTotal
{
    using Cartera;

    #region Librerias

    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using NegociosCartera;
    using System;
    using System.Windows.Forms;

    //JAVIER ENRIQUE VILLALBA ESPINOSA
    //Agosto 27 2020

    #endregion Librerias

    public partial class XtraRecaudos : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Propiedades

        public string StrFuente = string.Empty;
        private BindingSource BsRecaudos = new BindingSource();
        private CadenaConexionMysql CadenaConexion;
        private negDocumentacion doc;
        private negRecaudos NegRecaudos;
        private string StrIdAdjudicacion = string.Empty;
        private string StrOperacion = string.Empty;

        #endregion Propiedades

        #region Constructor

        public XtraRecaudos(CadenaConexionMysql cadenaConexion, string strFuente, string strIdAdjudicacion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            StrFuente = strFuente;
            StrIdAdjudicacion = strIdAdjudicacion;
            CadenaConexion = cadenaConexion;
            doc = new negDocumentacion(CadenaConexion, StrIdAdjudicacion, "Pagado");
            NegRecaudos = new negRecaudos(cadenaConexion, strIdAdjudicacion);
            NegRecaudos.EventOkString += NegRecaudos_EventOkString;
            NegRecaudos.EventErrorString += NegRecaudos_EventErrorString;
            NegRecaudos.Event_ErrorTableNgRecaudos += NegRecaudos_Event_ErrorTableNgRecaudos;
            this.Text = "Adicionar Recaudos " + strIdAdjudicacion.ToUpper() + " " + NegRecaudos.DtAdjudicacion.Rows[0]["TitularPrincipal"];
            StrOperacion = "Adicionar";
            userDatosClientes1.Inicio(NegRecaudos);
            BsRecaudos.DataSource = NegRecaudos.EntDatosRecaudos;

            CmbOperacion.Properties.DataSource = NegRecaudos.DtOperacion;
            CmbOperacion.Properties.ValueMember = "Id";
            CmbOperacion.Properties.DisplayMember = "Operacion";

            CmbFormaPago.Properties.DataSource = NegRecaudos.CnsFormaPago(strFuente);
            CmbFormaPago.Properties.ValueMember = "FormaPago";
            CmbFormaPago.Properties.DisplayMember = "FormaPago";

            GrdCuotas.DataSource = NegRecaudos.CnsCuotas("TT", strIdAdjudicacion);

            TxtRecibo.DataBindings.Add("EditValue", BsRecaudos, "Recibo", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtCodBanco.DataBindings.Add("EditValue", BsRecaudos, "CodBanco", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtValor.DataBindings.Add("EditValue", BsRecaudos, "Valor", true, DataSourceUpdateMode.OnPropertyChanged);
            DtpFecha.DataBindings.Add("EditValue", BsRecaudos, "Fecha", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbOperacion.DataBindings.Add("EditValue", BsRecaudos, "Operacion", true, DataSourceUpdateMode.OnPropertyChanged);
            CmbFormaPago.DataBindings.Add("EditValue", BsRecaudos, "FormaPago", true, DataSourceUpdateMode.OnPropertyChanged);
            TxtDetalle.DataBindings.Add("EditValue", BsRecaudos, "Detalle", true, DataSourceUpdateMode.OnPropertyChanged);

            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constructor

        #region Disparadores

        private void Doc_Error_Event_String_NegDocumentacion(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Recaudos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Doc_Ok_Event_String_negDocumentacion(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Recaudos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void NegRecaudos_Event_ErrorTableNgRecaudos(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Recaudos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NegRecaudos_EventErrorString(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Recaudos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BtnGuardar.Enabled = true;

            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void NegRecaudos_EventOkString(string mensaje)
        {
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
            XtraMessageBox.Show(mensaje, "Recaudos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnImprimi.Enabled = true;

            decimal Saldo = NegRecaudos.MtdSaldo(StrIdAdjudicacion);
            if (Saldo <= 0)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                doc.Ok_Event_String_negDocumentacion += Doc_Ok_Event_String_negDocumentacion;
                doc.Error_Event_String_NegDocumentacion += Doc_Error_Event_String_NegDocumentacion;
                doc.EntDocumentacion.ComentariosEnvio = "Credito Pagado en Su Totalidad";
                doc.MtdEnviar();
                if (SplashScreenManager.Default != null)
                    SplashScreenManager.CloseForm();
            }
        }

        #endregion Disparadores

        #region Metodos

        private void BtnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnGuardar.Enabled = false;
            if (XtraMessageBox.Show("¿Esta Seguro de " + StrOperacion + " Este Recaudo?", StrOperacion + " Recaudos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));

                switch (StrOperacion)
                {
                    case "Adicionar":
                        NegRecaudos.MtdAdicionar(StrFuente);
                        break;

                    case "Modificar":

                        break;

                    case "Eliminar":

                        break;

                    case "Bloquear":

                        break;

                    case "Desbloquear":

                        break;
                }
            }
        }

        private void BtnImprimi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraRptReciboCaja Documento = new XtraRptReciboCaja(CadenaConexion, NegRecaudos.EntDatosRecaudos.IdRecaudo, NegRecaudos.EntDatosRecaudos.Valor);
            Documento.ShowDialog();
        }

        private void BtnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void CmbOperacion_EditValueChanged(object sender, EventArgs e)
        {
            if (CmbOperacion.EditValue != DBNull.Value)
            {
                GrdCuotas.DataSource = NegRecaudos.CnsCuotas(CmbOperacion.EditValue.ToString(), StrIdAdjudicacion);
                MtdCuotasPagar();
            }
        }

        private void DtpFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void MtdCuotasPagar()
        {
            decimal TotalRcd = 0;

            TotalRcd = Convert.ToDecimal(TxtValor.EditValue);

            for (int i = 0; i < (NegRecaudos.DtCuotas.Rows.Count); i++)
            {
                if (TotalRcd > Convert.ToDecimal(NegRecaudos.DtCuotas.Rows[i]["CuotaTotal"]))
                {
                    NegRecaudos.DtCuotas.Rows[i]["RcdCapital"] = NegRecaudos.DtCuotas.Rows[i]["SdoCapital"];
                    NegRecaudos.DtCuotas.Rows[i]["RcdInteres"] = NegRecaudos.DtCuotas.Rows[i]["SdoInteres"];
                    NegRecaudos.DtCuotas.Rows[i]["RcdMora"] = NegRecaudos.DtCuotas.Rows[i]["VrMora"];
                    NegRecaudos.DtCuotas.Rows[i]["RcdCuota"] = NegRecaudos.DtCuotas.Rows[i]["CuotaTotal"];
                    TotalRcd = TotalRcd - Convert.ToDecimal(NegRecaudos.DtCuotas.Rows[i]["CuotaTotal"]);
                }
                else
                {
                    if (TotalRcd > (Convert.ToDecimal(NegRecaudos.DtCuotas.Rows[i]["SdoInteres"]) + Convert.ToDecimal(NegRecaudos.DtCuotas.Rows[i]["VrMora"])))
                    {
                        NegRecaudos.DtCuotas.Rows[i]["RcdCuota"] = TotalRcd;

                        NegRecaudos.DtCuotas.Rows[i]["RcdMora"] = NegRecaudos.DtCuotas.Rows[i]["VrMora"];
                        TotalRcd = TotalRcd - Convert.ToDecimal(NegRecaudos.DtCuotas.Rows[i]["VrMora"]);

                        NegRecaudos.DtCuotas.Rows[i]["RcdInteres"] = NegRecaudos.DtCuotas.Rows[i]["SdoInteres"];
                        TotalRcd = TotalRcd - Convert.ToDecimal(NegRecaudos.DtCuotas.Rows[i]["SdoInteres"]);
                        NegRecaudos.DtCuotas.Rows[i]["RcdCapital"] = TotalRcd;
                        TotalRcd = 0;
                    }
                    else
                    {
                        if (TotalRcd > Convert.ToDecimal(NegRecaudos.DtCuotas.Rows[i]["VrMora"]))
                        {
                            NegRecaudos.DtCuotas.Rows[i]["RcdCuota"] = TotalRcd;
                            NegRecaudos.DtCuotas.Rows[i]["RcdMora"] = NegRecaudos.DtCuotas.Rows[i]["VrMora"];
                            TotalRcd = TotalRcd - Convert.ToDecimal(NegRecaudos.DtCuotas.Rows[i]["VrMora"]);

                            NegRecaudos.DtCuotas.Rows[i]["RcdInteres"] = TotalRcd;
                            TotalRcd = 0;
                            NegRecaudos.DtCuotas.Rows[i]["RcdCapital"] = TotalRcd;
                        }
                        else
                        {
                            NegRecaudos.DtCuotas.Rows[i]["RcdCuota"] = TotalRcd;
                            NegRecaudos.DtCuotas.Rows[i]["RcdMora"] = TotalRcd;
                            TotalRcd = 0;
                            NegRecaudos.DtCuotas.Rows[i]["RcdInteres"] = TotalRcd;
                            NegRecaudos.DtCuotas.Rows[i]["RcdCapital"] = TotalRcd;
                        }
                    }
                }
            }
        }

        private void TxtValor_EditValueChanged(object sender, EventArgs e)
        {
            MtdCuotasPagar();
        }

        #endregion Metodos
    }
}