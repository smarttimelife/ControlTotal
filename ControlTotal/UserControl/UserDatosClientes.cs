using NegociosCartera;

//JAVIER ENRIQUE VILLALBA ESPINOSA
//Agosto 27 2020
namespace ControlTotal
{
    public partial class UserDatosClientes : DevExpress.XtraEditors.XtraUserControl
    {
        private negRecaudos NegRecaudos;

        public UserDatosClientes()
        {
            InitializeComponent();
        }

        public void Inicio(negRecaudos negocioRecaudos)
        {
            NegRecaudos = negocioRecaudos;
            TxtContrato.EditValue = NegRecaudos.DtAdjudicacion.Rows[0]["Contrato"];
            TxtInmueble.EditValue = NegRecaudos.DtAdjudicacion.Rows[0]["IdInmueble"];
            TxtValor.EditValue = NegRecaudos.DtAdjudicacion.Rows[0]["Valor"];
            TxtContado.EditValue = NegRecaudos.DtAdjudicacion.Rows[0]["Contado"];
            TxtAdjudicacion.EditValue = NegRecaudos.DtAdjudicacion.Rows[0]["IdAdjudicacion"];
            TxtTitular.EditValue = NegRecaudos.DtAdjudicacion.Rows[0]["TitularPrincipal"];
            TxtCuotaInicial.EditValue = NegRecaudos.DtAdjudicacion.Rows[0]["CuotaInicial"];
            TxtFinanciacion.EditValue = NegRecaudos.DtAdjudicacion.Rows[0]["Financiacion"];
            TxtExtraOrdinaria.EditValue = NegRecaudos.DtAdjudicacion.Rows[0]["Extraordinaria"];
            TxtRecaudo.EditValue = NegRecaudos.DtAdjudicacion.Rows[0]["RcdCapital"];
            TxtSaldo.EditValue = NegRecaudos.DtAdjudicacion.Rows[0]["RcdCapital"];
            TxtDiasMora.EditValue = NegRecaudos.DiasMoras;
            TxtValorMora.EditValue = NegRecaudos.SaldoMora;
            TxtNumCtasVdas.EditValue = NegRecaudos.CuotasVencidas;
            TxtCapitalVdo.EditValue = NegRecaudos.SdoCapitalVdo;
            TxtPagoMinimo.EditValue = NegRecaudos.PagoMinimo;
            TxtSaldo.EditValue = NegRecaudos.SdoCapital;
            TxtInteresCte.EditValue = NegRecaudos.InteresCteVdo;
            TxtPagoTotal.EditValue = NegRecaudos.TotalPagar;
        }
    }
}