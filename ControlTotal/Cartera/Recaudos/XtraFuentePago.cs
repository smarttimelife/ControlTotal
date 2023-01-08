using Conexiones;
using DevExpress.XtraEditors;
using NegociosCartera;
using System;
using System.Data;
using System.Windows.Forms;

namespace ControlTotal
{
    public partial class XtraFuentePago : DevExpress.XtraEditors.XtraForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private negReportes NegReportes;
        public static string botonpresionado;
        public static string strfuente;
        public static int ent = 0;
        public static string StrFuenteRecibo;

        #endregion Propiedades

        #region Constructores

        public XtraFuentePago(CadenaConexionMysql cadenaConexion)
        {
            InitializeComponent();
            CadenaConexion = cadenaConexion;
            NegReportes = new negReportes(CadenaConexion);

            NegReportes.Event_ErrorTableNgConsultas += NegReportes_Event_ErrorTableNgConsultas;
        }

        #endregion Constructores

        #region Disparadores

        private void NegReportes_Event_ErrorTableNgConsultas(string mensaje, DataTable dataTable)
        {
            XtraMessageBox.Show(mensaje, " Fuente de Pagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Disparadores

        #region Metodos

        private void XtraFuentePago_Load(object sender, EventArgs e)
        {
            CmbFuente.Properties.DataSource = NegReportes.CnsDtCombox("Fuente");
            CmbFuente.Properties.ValueMember = "Fuente";
            CmbFuente.Properties.DisplayMember = "Oficina";
        }

        #endregion Metodos

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            botonpresionado = "SALIR";
            Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            botonpresionado = "ACEPTAR";

            if (CmbFuente.EditValue == null)
            {
                XtraMessageBox.Show("Seleccione Fuente Pago", " Fuente de Pagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                strfuente = CmbFuente.Text;
                StrFuenteRecibo = CmbFuente.EditValue.ToString();
                Close();
            }
        }
    }
}