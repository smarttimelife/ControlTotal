namespace ControlTotal
{
    using Conexiones;
    using DevExpress.LookAndFeel;
    using DevExpress.Skins;
    using DevExpress.UserSkins;
    using System;
    using System.Windows.Forms;

    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        private static void Main()

        {
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Black");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var Puerto = Properties.Settings.Default.Puerto;
            var Ip = Properties.Settings.Default.Ip;
            var database = Properties.Settings.Default.BaseDatos;
            Operaciones.Clave = "elpobladosa";
            CadenaConexionMysql CadenaConexion = new CadenaConexionMysql(Ip, database, Puerto, "root", Operaciones.Clave);
           // CadenaConexionMysql CadenaConexion = new CadenaConexionMysql("127.0.0.1", "admin", "3306", "root", "elpobladosa");
            Application.Run(new XtraLogin(CadenaConexion));
        }
    }
}