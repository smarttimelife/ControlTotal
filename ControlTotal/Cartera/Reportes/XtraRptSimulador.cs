using Conexiones;
using ModelCartera;
using System.Data;

namespace ControlTotal
{
    public partial class XtraRptSimulador : DevExpress.XtraEditors.XtraForm
    {
        public XtraRptSimulador(CadenaConexionMysql cadenaConexion, simulador EntSimulador, DataTable Dt)
        {
            InitializeComponent();
            RptSimulador xtraReport1 = new RptSimulador(cadenaConexion.Logeo.Logo);
            Dt.DefaultView.Sort = "Fecha asc";
            xtraReport1.DataSource = Dt;
            xtraReport1.Parameters["Fecha"].Value = EntSimulador.Fecha;
            xtraReport1.Parameters["Cliente"].Value = EntSimulador.Cliente;
            xtraReport1.Parameters["Venta"].Value = EntSimulador.Prestamo;
            xtraReport1.Parameters["Inicial"].Value = EntSimulador.CuotaInicial;
            xtraReport1.Parameters["Financiacion"].Value = EntSimulador.Financiacion;
            xtraReport1.Parameters["CuotaFnc"].Value = EntSimulador.CuotaFnc;
            xtraReport1.Parameters["PlazoFnc"].Value = EntSimulador.PlazoFnc;
            xtraReport1.Parameters["Extraordinaria"].Value = EntSimulador.Extraordinaria;
            xtraReport1.Parameters["CuotaExtra"].Value = EntSimulador.CuotaExtra;
            xtraReport1.Parameters["PlazoExtra"].Value = EntSimulador.PlazoExtra;

            documentViewer1.DocumentSource = xtraReport1;
            xtraReport1.CreateDocument();
        }
    }
}