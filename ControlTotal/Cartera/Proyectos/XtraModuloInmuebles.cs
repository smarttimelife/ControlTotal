namespace ControlTotal
{
    #region Librerias

    using Conexiones;
    using DevExpress.Utils;
    using DevExpress.XtraEditors;
    using DevExpress.XtraGrid;
    using DevExpress.XtraSplashScreen;
    using NegociosCartera;
    using System.Windows.Forms;

    #endregion Librerias

    public partial class XtraModuloInmuebles : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private neginmuebles NegInmuebles;
        private string StrModulo = string.Empty;

        #endregion Propiedades

        #region Constructores

        public XtraModuloInmuebles(CadenaConexionMysql cadenaConexion, string strModulo)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegInmuebles = new neginmuebles(CadenaConexion);
            StrModulo = strModulo;           
            GrdInmuebles.DataSource = NegInmuebles.CnsDtConsulta("Inmuebles");
            MtdColumna();
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }        

        #endregion Constructores



        #region Disparadores

        private void NegInmuebles_ErrorString_Event_inmuebles(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Modulo Inmuebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NegInmuebles_Event_ErrorTableNgConsultas(string mensaje, System.Data.DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, "Modulo Inmuebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NegInmuebles_OkString_Event_inmuebles(string mensaje)
        {
            XtraMessageBox.Show(mensaje, "Modulo Inmuebles", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion Disparadores



        #region Metodos

        private void BtnAdicionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnAdicionar.Enabled = false;
            XtraInmuebles Documento = new XtraInmuebles(CadenaConexion, StrModulo);
            Documento.ShowDialog();
            BtnAdicionar.Enabled = true;
            GrdInmuebles.DataSource = NegInmuebles.CnsDtConsulta("Inmuebles");
        }

        private void BtnBloquear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvInmuebles.DataRowCount > 0)
            {
                string Id = GrvInmuebles.GetFocusedRowCellValue("IdInmueble").ToString();
                BtnBloquear.Enabled = false;
                XtraInmuebles Documento = new XtraInmuebles(CadenaConexion, StrModulo, Id, "Bloquear");
                Documento.ShowDialog();
                BtnBloquear.Enabled = true;
                GrdInmuebles.DataSource = NegInmuebles.CnsDtConsulta("Inmuebles");
            }
            else
            {
                XtraMessageBox.Show(" No Ahy Inmuebles Para Bloquear", "Modulo Inmuebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDesbloquear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvInmuebles.DataRowCount > 0)
            {
                string Id = GrvInmuebles.GetFocusedRowCellValue("IdInmueble").ToString();

                BtnDesbloquear.Enabled = false;
                XtraInmuebles Documento = new XtraInmuebles(CadenaConexion, StrModulo, Id, "Desbloquear");
                Documento.ShowDialog();
                BtnDesbloquear.Enabled = true;
                GrdInmuebles.DataSource = NegInmuebles.CnsDtConsulta("Inmuebles");
            }
            else
            {
                XtraMessageBox.Show(" No Ahy Inmuebles Para Desbloquear", "Modulo Inmuebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvInmuebles.DataRowCount > 0)
            {
                string Id = GrvInmuebles.GetFocusedRowCellValue("IdInmueble").ToString();
                BtnEliminar.Enabled = false;
                XtraInmuebles Documento = new XtraInmuebles(CadenaConexion, StrModulo, Id, "Eliminar");
                Documento.ShowDialog();
                BtnEliminar.Enabled = true;
                GrdInmuebles.DataSource = NegInmuebles.CnsDtConsulta("Inmuebles");
            }
            else
            {
                XtraMessageBox.Show(" No Ahy Inmuebles Para Eliminar", "Modulo Inmuebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            BtnImprimir.Enabled = false;
            Utilidades utilidades = new Utilidades();
            utilidades.impirmir(GrdInmuebles, "LISTADO GENERAL DE INMUEBLES", CadenaConexion.Logeo.Logo);
            BtnImprimir.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
            GrdInmuebles.DataSource = NegInmuebles.CnsDtConsulta("Inmuebles");
        }

        private void BtnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvInmuebles.DataRowCount > 0)
            {
                string Id = GrvInmuebles.GetFocusedRowCellValue("IdInmueble").ToString();
                BtnModificar.Enabled = false;
                XtraInmuebles Documento = new XtraInmuebles(CadenaConexion, StrModulo, Id, "Modificar");
                Documento.ShowDialog();
                BtnModificar.Enabled = true;
                GrdInmuebles.DataSource = NegInmuebles.CnsDtConsulta("Inmuebles");
            }
            else
            {
                XtraMessageBox.Show(" No Ahy Inmuebles Para Modificar", "Modulo Inmuebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GrvInmuebles_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (GrvInmuebles.DataRowCount > 0)
            {
                string Inmueble = (GrvInmuebles.GetFocusedRowCellValue("Estado").ToString());
                switch (Inmueble)
                {
                    case "Libre":
                        BtnModificar.Enabled = true;
                        BtnEliminar.Enabled = true;
                        BtnBloquear.Enabled = true;
                        BtnDesbloquear.Enabled = false;
                        break;

                    case "Adjudicado":
                        BtnModificar.Enabled = false;
                        BtnEliminar.Enabled = false;
                        BtnBloquear.Enabled = false;
                        BtnDesbloquear.Enabled = false;
                        break;

                    case "Bloqueado":
                        BtnModificar.Enabled = false;
                        BtnEliminar.Enabled = false;
                        BtnBloquear.Enabled = false;
                        BtnDesbloquear.Enabled = true;
                        break;

                    case "Reservado":
                        BtnModificar.Enabled = false;
                        BtnEliminar.Enabled = false;
                        BtnBloquear.Enabled = false;
                        BtnDesbloquear.Enabled = false;
                        break;

                    default:
                        BtnModificar.Enabled = false;
                        BtnEliminar.Enabled = false;
                        BtnBloquear.Enabled = false;
                        BtnDesbloquear.Enabled = false;
                        break;
                }
            }
        }

        private void Inicio()
        {
            NegInmuebles.Event_ErrorTableNgConsultas += NegInmuebles_Event_ErrorTableNgConsultas;
            NegInmuebles.ErrorString_Event_inmuebles += NegInmuebles_ErrorString_Event_inmuebles;
            NegInmuebles.OkString_Event_inmuebles += NegInmuebles_OkString_Event_inmuebles;
        
            BtnAdicionar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Adicionar;
            BtnModificar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Modificar;
            BtnEliminar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Eliminar;
            BtnBloquear.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Eliminar;
            BtnDesbloquear.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Eliminar;
            BtnImprimir.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Imprimir;
            BtnExportar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Imprimir;
        }

        private void BtnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void BtnExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(GrdInmuebles);
        }

        private void MtdColumna()
        {
            GridGroupSummaryItem item = new GridGroupSummaryItem();
            item.FieldName = "Id";
            item.SummaryType = DevExpress.Data.SummaryItemType.Count;
            GrvInmuebles.GroupSummary.Add(item);
            item.DisplayFormat = "{0:n0}";
            item.ShowInGroupColumnFooter = GrvInmuebles.Columns["Id"];
            GrvInmuebles.Columns["Id"].DisplayFormat.FormatType = FormatType.Numeric;
            GrvInmuebles.Columns["Id"].Summary.Clear();
            GrvInmuebles.Columns["Id"].Summary.Add(DevExpress.Data.SummaryItemType.Count, "{0:n0}");
        }

        #endregion Metodos

        private void XtraModuloInmuebles_Load(object sender, System.EventArgs e)
        {
            Inicio();
        }
    }
}