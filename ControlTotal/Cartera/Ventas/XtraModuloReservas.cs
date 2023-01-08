using Conexiones;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraSplashScreen;
using NegociosCartera;
using System;
using System.Windows.Forms;

namespace ControlTotal
{
    public partial class XtraModuloReservas : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private string StrModulo;
        private BindingSource BsReservas = new BindingSource();
        private negReservas NegReservas;
        private int count = 0;

        #endregion Propiedades

        #region Constrtuctores

        public XtraModuloReservas(CadenaConexionMysql cadenaConexion, string strModulo)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            StrModulo = strModulo;
            NegReservas = new negReservas(CadenaConexion);
            GrdReservas.DataSource = NegReservas.CnsDtConsulta("Reservas");
            NegReservas.Event_ErrorTableNgConsultas += NegReservas_Event_ErrorTableNgConsultas;
           
             
            MtdColumna();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        #endregion Constrtuctores

        #region Dsiparadores

        private void NegReservas_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Modulo Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Dsiparadores

        #region Metodos

        private void BtnAdicionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnAdicionar.Enabled = false;
            XtraReservas Documento = new XtraReservas(CadenaConexion, StrModulo);
            Documento.ShowDialog();
            BtnAdicionar.Enabled = true;
            GrdReservas.DataSource = NegReservas.CnsDtConsulta("Reservas");
        }

        private void BtnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvReservas.DataRowCount > 0)
            {
                int Id = Convert.ToInt32(GrvReservas.GetFocusedRowCellValue("Id").ToString());
                BtnModificar.Enabled = false;
                XtraReservas Documento = new XtraReservas(CadenaConexion, StrModulo, Id, "Modificar");
                Documento.ShowDialog();
                BtnModificar.Enabled = true;
                GrdReservas.DataSource = NegReservas.CnsDtConsulta("Reservas");
            }
            else
            {
                XtraMessageBox.Show("No ahy Reservas Para Modificar", "Modulo Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvReservas.DataRowCount > 0)
            {
                int Id = Convert.ToInt32(GrvReservas.GetFocusedRowCellValue("Id").ToString());
                BtnEliminar.Enabled = false;
                XtraReservas Documento = new XtraReservas(CadenaConexion, StrModulo, Id, "Eliminar");
                Documento.ShowDialog();
                BtnEliminar.Enabled = true;
                GrdReservas.DataSource = NegReservas.CnsDtConsulta("Reservas");
            }
            else
            {
                XtraMessageBox.Show("No ahy Reservas Para Eliminar", "Modulo Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GrvReservas_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (GrvReservas.DataRowCount > 0)
            {
                string Nomina = (GrvReservas.GetFocusedRowCellValue("Estado").ToString());
                switch (Nomina)
                {
                    case "Pendiente":
                        BtnModificar.Enabled = true;
                        BtnEliminar.Enabled = true;

                        break;

                    case "Adjudicado":

                        break;

                    case "Bloqueado":

                        break;

                    case "Reservado":

                        break;

                    default:
                        BtnModificar.Enabled = false;
                        BtnEliminar.Enabled = false;
                        break;
                }
            }
        }

        private void XtraModuloReservas_Activated(object sender, EventArgs e)
        {
            if (count > 0)
            {
                GrdReservas.DataSource = NegReservas.CnsDtConsulta("Reservas");
            }
            count += 1;
        }

        private void BtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            BtnImprimir.Enabled = false;
            Utilidades utilidades = new Utilidades();
            utilidades.impirmir(GrdReservas, "LISTADO GENERAL DE RESERVAS", CadenaConexion.Logeo.Logo);
            BtnImprimir.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void BtnExportarExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(GrdReservas);
        }

        private void BtnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void MtdColumna()
        {
            GridGroupSummaryItem itemId = new GridGroupSummaryItem();
            itemId.FieldName = "Id";
            itemId.SummaryType = DevExpress.Data.SummaryItemType.Count;
            GrvReservas.GroupSummary.Add(itemId);
            itemId.DisplayFormat = "{0:n0}";
            itemId.ShowInGroupColumnFooter = GrvReservas.Columns["Id"];
            GrvReservas.Columns["Id"].DisplayFormat.FormatType = FormatType.Numeric;
            GrvReservas.Columns["Id"].Summary.Clear();
            GrvReservas.Columns["Id"].Summary.Add(DevExpress.Data.SummaryItemType.Count, "Id", "{0:n0}");

            GridGroupSummaryItem itemValor = new GridGroupSummaryItem();
            itemValor.FieldName = "ValorContrato";
            itemValor.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            GrvReservas.GroupSummary.Add(itemValor);
            itemValor.DisplayFormat = "{0:n2}";

            itemValor.ShowInGroupColumnFooter = GrvReservas.Columns["ValorContrato"];
            GrvReservas.Columns["ValorContrato"].DisplayFormat.FormatType = FormatType.Numeric;
            GrvReservas.Columns["ValorContrato"].DisplayFormat.FormatString = "{0:n2}";
            GrvReservas.Columns["ValorContrato"].Summary.Clear();
            GrvReservas.Columns["ValorContrato"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "ValorContrato", "{0:n2}");
        }

        #endregion Metodos

        private void XtraModuloReservas_Load(object sender, EventArgs e)
        {
            BtnAdicionar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Adicionar;
            BtnModificar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Modificar;
            BtnEliminar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Eliminar;
            BtnImprimir.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Imprimir;
        }
    }
}