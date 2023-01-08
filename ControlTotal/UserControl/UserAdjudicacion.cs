using Cartera;
using Conexiones;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace ControlTotal
{
    public partial class UserAdjudicacion : DevExpress.XtraEditors.XtraUserControl
    {
        public UserAdjudicacion()
        {
            InitializeComponent();
        }

        public void Inicio(CadenaConexionMysql CadenaConexion, string StrIdAdjudicacion)
        {
            try
            {
                DataTable DtAdjudicacion = new DataTable();
                negConsultas NegConsultas = new negConsultas(CadenaConexion);
                NegConsultas.Event_ErrorTableNgConsultas += NegConsultas_Event_ErrorTableNgConsultas;
                DtAdjudicacion = NegConsultas.CnsDtConsultaStrId("ViewAdjudicacion", StrIdAdjudicacion);
                TxtContrato.EditValue = DtAdjudicacion.Rows[0]["Contrato"];
                TxtInmueble.EditValue = DtAdjudicacion.Rows[0]["IdInmueble"];
                TxtValor.EditValue = DtAdjudicacion.Rows[0]["Valor"];
                TxtContado.EditValue = DtAdjudicacion.Rows[0]["Contado"];
                TxtAdjudicacion.EditValue = DtAdjudicacion.Rows[0]["IdAdjudicacion"];
                TxtSegundoTitular.EditValue = DtAdjudicacion.Rows[0]["SegundoTitular"];
                TxtTitular.EditValue = DtAdjudicacion.Rows[0]["TitularPrincipal"];
                TxtCuotaInicial.EditValue = DtAdjudicacion.Rows[0]["CuotaInicial"];
                TxtFinanciacion.EditValue = DtAdjudicacion.Rows[0]["Financiacion"];
                TxtExtraOrdinaria.EditValue = DtAdjudicacion.Rows[0]["Extraordinaria"];
                TxtRecaudo.EditValue = DtAdjudicacion.Rows[0]["RcdCapital"];
                TxtSaldo.EditValue = DtAdjudicacion.Rows[0]["Saldo"];
                DtpFechaEntrega.EditValue = DtAdjudicacion.Rows[0]["FechaEntrega"];
                TxtEstado.EditValue = DtAdjudicacion.Rows[0]["Estado"];
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "User Datos Adjudicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NegConsultas_Event_ErrorTableNgConsultas(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "User Datos Adjudicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}