namespace ControlTotal
{
    #region Librerias

    using DevExpress.XtraEditors;
    using DevExpress.XtraGrid;
    using DevExpress.XtraPrinting;
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    //Creado Por Javier Villalba Espinosa
    //Marzo 30 2020 13:25 PM

    #endregion Librerias

    public class Utilidades
    {
        #region Propiedades

        private string Titulo = string.Empty;
        private Image MiLogo;

        //IdEmpresa

        #endregion Propiedades

        #region Metodos

        public decimal MtdCalculoCuota(int decimales, double Tasa, int Periodo, int Plazo)
        {
            double CuotaFijaCalculada;
            double PeriodoC = Periodo;
            double Valor = 0;

            try
            {
                PeriodoC = (30 / PeriodoC) * 12;
                if (Tasa > 0)
                {
                    double a, b, x;

                    a = (1 + Tasa / (PeriodoC * 100));
                    b = Plazo;
                    x = Math.Pow(a, b);
                    x = 1 / x;
                    x = 1 - x;
                    CuotaFijaCalculada = Valor * (Tasa / (PeriodoC * 100)) / x;
                }
                else
                {
                    CuotaFijaCalculada = Math.Round((Valor / Plazo), decimales);
                }
                return Convert.ToDecimal(Math.Round(CuotaFijaCalculada, decimales));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Se Presento el Sgte Error en el metodo Utilidades.MtdCalculoCuota " + ex.Message, "MtdCalculoCuota", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        #region Impresion

        public void impirmir(GridControl GrdGrilla, string MiTitulo, byte[] logo)
        {
            Titulo = MiTitulo;
            if (logo != null)
            {
                MiLogo = byteArrayToImage(logo);
            }

            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = GrdGrilla;
            link.CreateMarginalHeaderArea += new CreateAreaEventHandler(Link_CreateMarginalHeaderArea);
            link.CreateDocument();
            link.ShowPreview();
        }

        public void impirmir(GridControl GrdGrilla, string MiTitulo)
        {
            Titulo = MiTitulo;

            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = GrdGrilla;
            link.CreateMarginalHeaderArea += new CreateAreaEventHandler(Link_CreateMarginalHeaderArea);
            link.CreateDocument();
            link.ShowPreview();
        }

        private void Link_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            TextBrick brick;
            ImageBrick imagen;
            brick = e.Graph.DrawString(Titulo, Color.Navy, new RectangleF(160, 0, 455, 60), DevExpress.XtraPrinting.BorderSide.None);
            imagen = e.Graph.DrawImage(MiLogo, new RectangleF(10, 0, 150, 50), DevExpress.XtraPrinting.BorderSide.None, Color.Transparent);
            brick.Font = new Font("Calibri", 14, System.Drawing.FontStyle.Bold);
            //brick.BackColor = Color.Green*  ;
            brick.ForeColor = Color.Gray;
            brick.StringFormat = new DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center);
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }

        public void ExportarExcelGrilla(GridControl GrdGrilla)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Buscar Ruta";
            dlg.Filter = "Todos Los Archivos Xlsx | *.xlsx";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                GrdGrilla.ExportToXlsx(dlg.FileName);
            }
        }

        #endregion Impresion

        #endregion Metodos
    }
}