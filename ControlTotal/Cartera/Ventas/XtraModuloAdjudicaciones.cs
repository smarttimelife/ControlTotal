namespace ControlTotal
{
    #region Librerias

    using Conexiones;
    using DevExpress.XtraEditors;
    using DevExpress.XtraGrid.Views.Grid;
    using DevExpress.XtraSplashScreen;
    using NegociosCartera;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    #endregion Librerias

    public partial class XtraModuloAdjudicaciones : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades
        public int count = 0;
        private CadenaConexionMysql CadenaConexion;
        private negAdjudicacion NegAdjudicacion;
        private string StrModulo = string.Empty;
        #endregion 

        #region Constructores
        public XtraModuloAdjudicaciones(CadenaConexionMysql cadenaConexion, string strModulo)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegAdjudicacion = new negAdjudicacion(CadenaConexion);
            StrModulo = strModulo;
            GrdAdjudicacion.DataSource = NegAdjudicacion.CnsDtConsulta("Adjudicaciones");

            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }
        #endregion  

        #region Metodos

        private void BtnAdicionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnAdicionar.Enabled = false;
            XtraAdjudicacion Documento = new XtraAdjudicacion(CadenaConexion, StrModulo);
            Documento.Show();
            BtnAdicionar.Enabled = true;
            GrdAdjudicacion.DataSource = NegAdjudicacion.CnsDtConsulta("Adjudicaciones");
        }

        private void BtnAprobar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvAdjudicacion.DataRowCount > 0)
            {
                string Id = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
                BtnAprobar.Enabled = false;
                XtraAdjudicacion Documento = new XtraAdjudicacion(CadenaConexion, StrModulo, Id, "Aprobar");
                Documento.ShowDialog();
                BtnAprobar.Enabled = true;
                GrdAdjudicacion.DataSource = NegAdjudicacion.CnsDtConsulta("Adjudicacion");
            }
            else
            {
                XtraMessageBox.Show("No ahy Adjudicacion Para Aprobar", "Modulo Adjudicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GrdAdjudicacion.DataSource = NegAdjudicacion.CnsDtConsulta("Adjudicaciones");
        }

        private void BtnDesaprobar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvAdjudicacion.DataRowCount > 0)
            {
                string Id = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
                BtnModificar.Enabled = false;
                XtraAdjudicacion Documento = new XtraAdjudicacion(CadenaConexion, StrModulo, Id, "Desaprobar");
                Documento.ShowDialog();
                BtnModificar.Enabled = true;
                GrdAdjudicacion.DataSource = NegAdjudicacion.CnsDtConsulta("Adjudicacion");
            }
            else
            {
                XtraMessageBox.Show("No ahy Adjudicacion Para Desaporbar", "Modulo Adjudicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GrdAdjudicacion.DataSource = NegAdjudicacion.CnsDtConsulta("Adjudicaciones");
        }

        private void BtnDesistir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string Id = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
            XtraDocumentacion Documento = new XtraDocumentacion(CadenaConexion, Id, "Desistido");
            Documento.ShowDialog();
            GrdAdjudicacion.DataSource = NegAdjudicacion.CnsDtConsulta("Adjudicacion");
        }

        private void BtnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvAdjudicacion.DataRowCount > 0)
            {
                string Id = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
                BtnModificar.Enabled = false;
                XtraAdjudicacion Documento = new XtraAdjudicacion(CadenaConexion, StrModulo, Id, "Eliminar");
                Documento.ShowDialog();
                BtnModificar.Enabled = true;
                GrdAdjudicacion.DataSource = NegAdjudicacion.CnsDtConsulta("Adjudicaciones");
            }
            else
            {
                XtraMessageBox.Show("No ahy Adjudicacion Para Modificar", "Modulo Adjudicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarExel(GrdAdjudicacion);
        }

        private void BtnExportarPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Operaciones.ExportarPdf(GrdAdjudicacion);
        }

        private void BtnImpComisiones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvAdjudicacion.DataRowCount > 0)
            {
                string IdAdj = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
                BtnImpComisiones.Enabled = false;
                XtraRptComision Documento = new XtraRptComision(CadenaConexion, IdAdj);
                Documento.ShowDialog();
                BtnImpComisiones.Enabled = true;
            }
        }

        private void BtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            BtnImprimir.Enabled = false;
            Utilidades utilidades = new Utilidades();
            utilidades.impirmir(GrdAdjudicacion, "LISTADO GENERAL DE ADJUDICACION", CadenaConexion.Logeo.Logo);
            BtnImprimir.Enabled = true;
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void BtnImprimirAdjudicacion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvAdjudicacion.DataRowCount > 0)
            {
                string IdAdj = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
                BtnImprimirAdjudicacion.Enabled = false;
                XtraRptAdjudicacion Documento = new XtraRptAdjudicacion(CadenaConexion, IdAdj);
                Documento.ShowDialog();
                BtnImprimirAdjudicacion.Enabled = true;
            }
        }

        private void BtnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvAdjudicacion.DataRowCount > 0)
            {
                string Id = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
                decimal Recaduo = Convert.ToDecimal(GrvAdjudicacion.GetFocusedRowCellValue("RcdCapital").ToString()) +
                    Convert.ToDecimal(GrvAdjudicacion.GetFocusedRowCellValue("RcdInteres").ToString());

                if (Recaduo > 0)
                {
                    XtraMessageBox.Show("Adjudicacion No Se Puede Modificar, Tiene Recaudos Registrados", "Modulo Adjudicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    BtnModificar.Enabled = false;
                    XtraAdjudicacion Documento = new XtraAdjudicacion(CadenaConexion, StrModulo, Id, "Modificar");
                    Documento.ShowDialog();
                    BtnModificar.Enabled = true;
                    GrdAdjudicacion.DataSource =NegAdjudicacion.CnsDtConsulta("Adjudicaciones");
                }
            }
            else
            {
                XtraMessageBox.Show("No ahy Adjudicacion Para Modificar", "Modulo Adjudicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModRadicacion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvAdjudicacion.DataRowCount > 0)
            {
                BtnRadicar.Enabled = false;
                string Id = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
                decimal PagoCom = Convert.ToDecimal(GrvAdjudicacion.GetFocusedRowCellValue("TasaPagada"));

                if (PagoCom > 0)
                {
                    XtraMessageBox.Show("Adjudicacion Ya Tiene Pagado el " + PagoCom + " % De Comision", "Modulo Adjudicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XtraRadicacion Documento = new XtraRadicacion(CadenaConexion, Id, "Modificar");
                    Documento.ShowDialog();
                    GrdAdjudicacion.DataSource = NegAdjudicacion.CnsDtConsulta("Adjudicacion");
                }
            }
            else
            {
                XtraMessageBox.Show("No ahy Adjudicacion Para Modificar", "Modulo Adjudicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRadicar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GrvAdjudicacion.DataRowCount > 0)
            {
                BtnRadicar.Enabled = false;
                string Id = GrvAdjudicacion.GetFocusedRowCellValue("IdAdjudicacion").ToString();
                XtraRadicacion Documento = new XtraRadicacion(CadenaConexion, Id);
                Documento.ShowDialog();
                GrdAdjudicacion.DataSource = NegAdjudicacion.CnsDtConsulta("Adjudicacion");
            }
            else
            {
                XtraMessageBox.Show("No ahy Adjudicacion Para Radicar", "Modulo Adjudicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GrvAdjudicacion_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (GrvAdjudicacion.DataRowCount > 0)
            {
                BtnImprimir.Enabled = true;
                string Estado = (GrvAdjudicacion.GetFocusedRowCellValue("Estado").ToString());
                switch (Estado)
                {
                    case "Pendiente":
                        BtnModificar.Enabled = true;
                        BtnEliminar.Enabled = true;
                        BtnAprobar.Enabled = true;
                        BtnDesaprobar.Enabled = false;
                        BtnDesistir.Enabled = false;
                        break;

                    case "Aprobado":
                        BtnModificar.Enabled = false;
                        BtnEliminar.Enabled = false;
                        BtnAprobar.Enabled = false;
                        BtnDesaprobar.Enabled = true;
                        BtnDesistir.Enabled = true;
                        break;

                    case "Pagado":
                        BtnModificar.Enabled = false;
                        BtnEliminar.Enabled = false;
                        BtnAprobar.Enabled = false;
                        BtnDesaprobar.Enabled = false;
                        BtnDesistir.Enabled = false;
                        break;

                    default:
                        BtnModificar.Enabled = false;
                        BtnEliminar.Enabled = false;
                        BtnAprobar.Enabled = false;
                        BtnDesaprobar.Enabled = false;
                        BtnDesistir.Enabled = false;
                        BtnDesistir.Enabled = false;
                        break;
                }

                string Radicado = (GrvAdjudicacion.GetFocusedRowCellValue("Radicado").ToString());
                switch (Radicado)
                {
                    case "Pendiente":
                        BtnRadicar.Enabled = true;
                        BtnModRadicacion.Enabled = false;
                        BtnImpComisiones.Enabled = false;
                        break;

                    case "Radicado":
                        BtnRadicar.Enabled = false;
                        BtnModRadicacion.Enabled = true;
                        BtnImpComisiones.Enabled = true;
                        break;
                }
            }
            else
            {
                BtnImprimir.Enabled = false;
            }
        }

        private void GrvAdjudicacion_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string Documen = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Estado"]);
                if (Documen == "Aprobado")
                {
                    e.Appearance.BackColor = Color.Aquamarine;
                    //e.Appearance.ForeColor = Color.White;
                }
            }
        }

        private void Inicio()
        {
            BtnAdicionar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Adicionar;
            BtnModificar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Modificar;
            BtnEliminar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Eliminar;
            BtnAprobar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Aprobar;
            BtnDesaprobar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Desaprobar;
            BtnImprimir.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Imprimir;
            BtnModRadicacion.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == "C303").Modificar;
            BtnRadicar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == "C303").Adicionar;
            BtnImpComisiones.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == "C303").Imprimir;
            BtnImprimirAdjudicacion.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Imprimir;
            BtnExportarPdf.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Imprimir;
            BtnExportar.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == StrModulo).Imprimir;
            BtnDesistir.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == "C304").Adicionar;
        }

        private void XtraModuloAdjudicacion_Activated(object sender, EventArgs e)
        {
            if (count > 0)
            {
                GrdAdjudicacion.DataSource = NegAdjudicacion.CnsDtConsulta("Adjudicacion");
            }
            else
            {
                Inicio();
            }
            count += 1;
        }

        #endregion Metodos
    }
}