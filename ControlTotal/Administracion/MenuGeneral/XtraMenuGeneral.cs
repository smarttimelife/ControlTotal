namespace ControlTotal
{
    #region Librerias

    //@Javier Enrique Villalba Espinosa
    //@Junio 29 2020
    using Administracion.NegociosAdmin;
    using Conexiones;
    using DevExpress.LookAndFeel;
    using DevExpress.XtraBars;
    using DevExpress.XtraEditors;
    using DevExpress.XtraSplashScreen;
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;

    #endregion Librerias

    public partial class XtraMenuGeneral : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Propiedades

        private CadenaConexionMysql CadenaConexion;
        private CadenaConexionMysql CadenaConexionCartera;
        private CadenaConexionMysql CadenaConexionContab;
        private negMenuGeneral NegMenuGeneral;

        #endregion Propiedades

        #region Constructor y Menu

        public XtraMenuGeneral(CadenaConexionMysql cadenasConexion)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            PtbImagen.EditValue = cadenasConexion.Logeo.Imagen;
            manager.MdiParent = this;
            CadenaConexion = cadenasConexion;
            NegMenuGeneral = new negMenuGeneral(CadenaConexion);
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        private void ConfiguracionRegional()
        {
            CultureInfo forceDotCulture;
            forceDotCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            CadenaConexion.Logeo.StrUsuarioConextado = NegMenuGeneral.NombrePropio(CadenaConexion.Logeo.StrUsuarioConextado, forceDotCulture);
            forceDotCulture.NumberFormat.NumberDecimalSeparator = ".";
            forceDotCulture.NumberFormat.NumberGroupSeparator = ",";
            forceDotCulture.NumberFormat.CurrencyDecimalSeparator = ".";
            forceDotCulture.NumberFormat.CurrencyGroupSeparator = ",";
            Thread.CurrentThread.CurrentCulture = forceDotCulture;
            string strDecimal1 = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            string strMiles1 = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator;
            string strDecimal2 = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            string strMiles2 = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator;
            if (strDecimal1 == "," || strMiles1 == "." || strDecimal2 == "," || strMiles2 == ".")
            {
                XtraMessageBox.Show("Por favor Cambie su Configuracion Regional. \n\nCambie los Decimales ( , )  por ( . ) y los Miles ( . ) por ( , ). \n\nVaya a: \nInicio/ Panel de control/ Reloj, idioma y región/ Región/ Configuración Adicional --(en Numero y Moneda) ", "Logeo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void MtdModulo()
        {
            #region Inicializacion de Botones y Modulos
            RpgCartera.Visible = true;
            RpgAdminsitracion.Visible = true;
            RpgConsultaCartera.Visible = true;
            RpgParametrosCartera.Visible = true;
            RpgModulosProyectos.Visible = false;
            RpgModuloVentas.Visible = false;
            RpgModuloCarteras.Visible = false;
            RpgModuloComisiones.Visible = false;
            RpgPresupuesto.Visible = false;
            RpgDocumentacion.Visible = false;
            RogConsultas.Visible = false;
            RpgCnsComisiones.Visible = false;
            RpgCnsPresupuesto.Visible = false;
            RpgParametros.Visible = false;
            RpgTerceros.Visible = false;
            RpgUsuarios.Visible = false; 
            #endregion

            #region Validacion de Cada Boton
            for (int i = 0; i < ribbon.Items.Count - 1; i++)
            {
                if (!string.IsNullOrEmpty(ribbon.Items[i].ToString()))
                {
                    if (!string.IsNullOrEmpty(ribbon.Items[i].Tag.ToString()))
                    {
                        if (ribbon.Items[i].Tag.ToString() == "0")
                        {
                            ribbon.Items[i].Links[0].Visible = true;
                        }
                        else
                        {
                            ribbon.Items[i].Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == ribbon.Items[i].Tag.ToString()).Ver;
                        }
                    }
                }
            }           

            BtnAddUsuarios.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == BtnAddUsuarios.Tag.ToString()).Adicionar;
            BtnAddReservas.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == BtnAddReservas.Tag.ToString()).Adicionar;
            BtnAddAdjudicacion.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == BtnAddAdjudicacion.Tag.ToString()).Adicionar;
            BtnAddOtrosi.Links[0].Visible = CadenaConexion.Logeo.LstMyRoldetalles.Find(f => f.IdFormulario == BtnAddOtrosi.Tag.ToString()).Adicionar;
            #endregion

            #region Validacion Cada Modulo
            for (int i = 0; i < RpgModulosProyectos.ItemLinks.Count - 1; i++)
            {
                if (RpgModulosProyectos.ItemLinks[i].Visible == true)
                {
                    RpgModulosProyectos.Visible = true;
                }
            }

            for (int i = 0; i < RpgModuloVentas.ItemLinks.Count - 1; i++)
            {
                if (RpgModuloVentas.ItemLinks[i].Visible == true)
                {

                    RpgModuloVentas.Visible = true;
                }
            }
            for (int i = 0; i < RpgModuloCarteras.ItemLinks.Count - 1; i++)
            {
                if (RpgModuloCarteras.ItemLinks[i].Visible == true)
                {

                    RpgModuloCarteras.Visible = true;
                }
            }
            for (int i = 0; i < RpgModuloComisiones.ItemLinks.Count - 1; i++)
            {
                if (RpgModuloComisiones.ItemLinks[i].Visible == true)
                {

                    RpgModuloComisiones.Visible = true;
                }
            }
            for (int i = 0; i < RpgPresupuesto.ItemLinks.Count - 1; i++)
            {
                if (RpgPresupuesto.ItemLinks[i].Visible == true)
                {

                    RpgPresupuesto.Visible = true;
                }
            }

            for (int i = 0; i < RpgDocumentacion.ItemLinks.Count - 1; i++)
            {
                if (RpgDocumentacion.ItemLinks[i].Visible == true)
                {
                    RpgDocumentacion.Visible = true;
                }
            }

            for (int i = 0; i < RogConsultas.ItemLinks.Count - 1; i++)
            {
                if (RogConsultas.ItemLinks[i].Visible == true)
                {
                    RogConsultas.Visible = true;
                }
            }

            for (int i = 0; i < RpgCnsComisiones.ItemLinks.Count - 1; i++)
            {
                if (RpgCnsComisiones.ItemLinks[i].Visible == true)
                {
                    RpgCnsComisiones.Visible = true;
                }
            }

            for (int i = 0; i < RpgCnsPresupuesto.ItemLinks.Count - 1; i++)
            {
                if (RpgCnsPresupuesto.ItemLinks[i].Visible == true)
                {
                    RpgCnsPresupuesto.Visible = true;
                }
            }
            for (int i = 0; i < RpgParametros.ItemLinks.Count - 1; i++)
            {
                if (RpgParametros.ItemLinks[i].Visible == true)
                {
                    RpgParametros.Visible = true;
                }
            }

            for (int i = 0; i < RpgTerceros.ItemLinks.Count - 1; i++)
            {
                if (RpgTerceros.ItemLinks[i].Visible == true)
                {
                    RpgTerceros.Visible = true;
                }
            }
            for (int i = 0; i < RpgUsuarios.ItemLinks.Count - 1; i++)
            {
                if (RpgUsuarios.ItemLinks[i].Visible == true)
                {
                    RpgUsuarios.Visible = true;
                }
            }

            #endregion          

            #region Validacion de Cada Pagina
            if (RpgTerceros.Visible == false & RpgUsuarios.Visible == false)
            {
                RpgAdminsitracion.Visible = false;
            }

            if (RpgParametros.Visible == false)
            {
                RpgParametrosCartera.Visible = false;
            }

            if (RogConsultas.Visible == false & RpgCnsComisiones.Visible == false & RpgCnsPresupuesto.Visible == false)
            {
                RpgConsultaCartera.Visible = false;
            }

            if (RpgModulosProyectos.Visible == false & RpgModuloVentas.Visible == false & RpgModuloCarteras.Visible == false & RpgModuloComisiones.Visible == false & RpgPresupuesto.Visible == false)
            {
                RpgCartera.Visible = false;
            } 
            #endregion
        } 
       

        private bool MtdValidarFormText(string strText)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Text == strText) // check by form name if it's opened
                {
                    item.BringToFront(); // bring it front
                    return true;
                }
            }
            return false;
        }

        private bool MtdValidarFormActiv(string strNmae)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == strNmae) // check by form name if it's opened
                {
                    item.BringToFront(); // bring it front
                    return true;
                }
            }
            return false;
        }

        private void MtdValidarFormActiv()
        {
            int canta = MdiChildren.Count();

            if (canta == 0)
            {
                PtbImagen.Visible = true;
            }
            else

                PtbImagen.Visible = false;
        }

        private void XtraMenuGeneral_FormClosed(object sender, FormClosedEventArgs e)
        {
            Operaciones.SaveSetting("ControlTotal", "Skin", "Tema", UserLookAndFeel.Default.SkinName.ToString());
        }

        private void XtraMenuGeneral_Load(object sender, EventArgs e)
        {
            ConfiguracionRegional();
            MtdModulo();
            barStaticItem1.Caption = CadenaConexion.Logeo.StrUsuarioConextado;
            CadenaConexionCartera = new CadenaConexionMysql(CadenaConexion.StrServidor, CadenaConexion.Logeo.BaseDatosCartera, CadenaConexion.StrPuerto, CadenaConexion.StrUsurioServer, CadenaConexion.StrClaveServer);
            CadenaConexionContab = new CadenaConexionMysql(CadenaConexion.StrServidor, CadenaConexion.Logeo.BaseDatosContab, CadenaConexion.StrPuerto, CadenaConexion.StrUsurioServer, CadenaConexion.StrClaveServer);
            CadenaConexionCartera.Logeo = CadenaConexion.Logeo;
            CadenaConexionContab.Logeo = CadenaConexion.Logeo;
        }

        #endregion Constructor y Menu

        #region Modulos de Administracion

        private void BtnAddUsuarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnAddUsuarios.Enabled = false;
            XtraUsuarios Documento = new XtraUsuarios(CadenaConexion, BtnAddUsuarios.Tag.ToString());
            Documento.ShowDialog();
            BtnAddUsuarios.Enabled = true;
        }

        private void BtnAsesores_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MtdValidarFormText(e.Item.Caption) == false)
            {
                new XtraModuloTerceros(CadenaConexion, 4, BtnClientes.Tag.ToString())
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
        }

        private void BtnCambioClave_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnCambioClave.Enabled = false;
            XtraReasignarClaves Documento = new XtraReasignarClaves(CadenaConexion);
            Documento.ShowDialog();
            BtnCambioClave.Enabled = true;
        }

        private void BtnClientes_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MtdValidarFormText(e.Item.Caption) == false)
            {
                new XtraModuloTerceros(CadenaConexion, 1, BtnClientes.Tag.ToString())
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
        }

        private void BtnEmpleados_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnEmpleados.Enabled = false;
            XtraTerceros Documento = new XtraTerceros(CadenaConexion, 3);
            Documento.Show();
            BtnEmpleados.Enabled = true;
        }

        private void BtnEmpresas_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnEmpresas.Enabled = false;
            if (MtdValidarFormActiv("XtraModuloEmpresas") == false)
            {
                new XtraModuloEmpresas(CadenaConexion, BtnEmpresas.Tag.ToString())
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnEmpresas.Enabled = true;
        }

        private void BtnProvedores_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnProvedores.Enabled = false;
            XtraTerceros Documento = new XtraTerceros(CadenaConexion, 2);
            Documento.Show();
            BtnProvedores.Enabled = true;
        }

        private void BtnRolesUsuarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnRolesUsuarios.Enabled = false;
            if (MtdValidarFormActiv("XtraModuloRoles") == false)
            {
                new XtraModuloRoles(CadenaConexion, BtnRolesUsuarios.Tag.ToString())
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnRolesUsuarios.Enabled = true;
        }

        private void BtnUsuarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnUsuarios.Enabled = false;
            if (MtdValidarFormActiv("XtraModuloUsuarios") == false)
            {
                new XtraModuloUsuarios(CadenaConexion, BtnUsuarios.Tag.ToString())
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnUsuarios.Enabled = true;
        }

        #endregion Modulos de Administracion

        #region Modulos de Cartera

        private void BtnAddAdjudicacion_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnAddAdjudicacion.Enabled = false;
            XtraAdjudicacion Documento = new XtraAdjudicacion(CadenaConexionCartera, BtnAddAdjudicacion.Tag.ToString());
            Documento.ShowDialog();
            BtnAddAdjudicacion.Enabled = true;
        }

        private void BtnAddOtrosi_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnAddOtrosi.Enabled = false;
            XtraOtrosi Documento = new XtraOtrosi(CadenaConexionCartera);
            Documento.ShowDialog();
            BtnAddOtrosi.Enabled = true;
        }

        private void BtnAddReservas_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnAddReservas.Enabled = false;
            XtraReservas Documento = new XtraReservas(CadenaConexionCartera, BtnReservas.Tag.ToString());
            Documento.ShowDialog();
            BtnAddReservas.Enabled = true;
        }

        private void BtnAdjudicacion_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnAdjudicacion.Enabled = false;
            if (MtdValidarFormActiv("XtraModuloAdjudicaciones") == false)
            {
                new XtraModuloAdjudicaciones(CadenaConexionCartera, BtnAddAdjudicacion.Tag.ToString())
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnAdjudicacion.Enabled = true;
        }

        private void BtnAnticipos_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnAnticipos.Enabled = false;
            if (MtdValidarFormActiv("XtraPagoAnticipos") == false)
            {
                new XtraPagoAnticipos(CadenaConexionCartera)
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnAnticipos.Enabled = true;
        }

        private void BtnAnticiposPdtes_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnAnticiposPdtes.Enabled = false;
            if (MtdValidarFormActiv("XtraAnticiposPendientes") == false)
            {
                new XtraAnticiposPendientes(CadenaConexionCartera)
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnAnticiposPdtes.Enabled = true;
        }

        private void BtnCalculadoraCuotas_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnCalculadoraCuotas.Enabled = false;
            if (MtdValidarFormActiv("XtraCalculoCuotas") == false)

            {
                new XtraCalculoCuotas(CadenaConexionCartera)
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnCalculadoraCuotas.Enabled = true;
        }

        private void BtnCarteraJuridica_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnCarteraJuridica.Enabled = false;
            if (MtdValidarFormActiv("XtraModuloRecaudoJuridico") == false)
            {
                new XtraModuloRecaudoJuridico(CadenaConexionCartera, BtnCarteraJuridica.Tag.ToString())
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnCarteraJuridica.Enabled = true;
        }

        private void BtnCarteraVigente_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnCarteraVigente.Enabled = false;
            if (MtdValidarFormActiv("XtraModuloRecaudosVigentes") == false)
            {
                new XtraModuloRecaudosVigentes(CadenaConexionCartera, BtnCarteraVigente.Tag.ToString())
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnCarteraVigente.Enabled = true;
        }

        private void BtnCnsComisionAsesor_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnCnsComisionAsesor.Enabled = false;
            if (MtdValidarFormActiv("XtraCnsComisionGestor") == false)
            {
                new XtraCnsComisionGestor(CadenaConexionCartera)
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnCnsComisionAsesor.Enabled = true;
        }

        private void BtnCnsPagoComisionesFecha_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnCnsPagoComisionesFecha.Enabled = false;
            if (MtdValidarFormActiv("XtraCnsComisionFecha") == false)
            {
                new XtraCnsComisionFecha(CadenaConexionCartera)
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnCnsPagoComisionesFecha.Enabled = true;
        }

        private void BtnCnsSeguimientoFecha_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnCnsSeguimientoFecha.Enabled = false;
            if (MtdValidarFormActiv("XtraCnsSeguimientos") == false)
            {
                new XtraCnsSeguimientos(CadenaConexionCartera)
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnCnsSeguimientoFecha.Enabled = true;
        }

        private void BtnComisiones_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnComisiones.Enabled = false;
            if (MtdValidarFormActiv("XtraPagoComision") == false)
            {
                new XtraPagoComision(CadenaConexionCartera)
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnComisiones.Enabled = true;
        }

        private void BtnComisionesPdtes_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnComisionesPdtes.Enabled = false;
            if (MtdValidarFormActiv("XtraComisionesPendientes") == false)
            {
                new XtraComisionesPendientes(CadenaConexionCartera)
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnComisionesPdtes.Enabled = true;
        }

        private void BtnConfigAnticipo_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnConfigAnticipo.Enabled = false;
            XtraConfigAnticipos Documento = new XtraConfigAnticipos(CadenaConexionCartera);
            Documento.ShowDialog();
            BtnConfigAnticipo.Enabled = true;
        }

        private void BtnFactores_ItemClick(object sender, ItemClickEventArgs e)
        {
            BrnFactores.Enabled = false;
            if (MtdValidarFormActiv("ModuloXtraFactores") == false)
            {
                new ModuloXtraFactores(CadenaConexionCartera)
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BrnFactores.Enabled = true;
        }

        private void BtnInmuebles_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnInmuebles.Enabled = false;
            if (MtdValidarFormActiv("XtraModuloInmuebles") == false)
            {
                new XtraModuloInmuebles(CadenaConexionCartera, BtnInmuebles.Tag.ToString())
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnInmuebles.Enabled = true;
        }

        private void BtnNegociosNoRadicados_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnNegociosNoRadicados.Enabled = false;
            XtraFuentePago Documento1 = new XtraFuentePago(CadenaConexionCartera);
            Documento1.ShowDialog();
            if (XtraFuentePago.botonpresionado == "ACEPTAR")
            {
                XtraRcdNoRadicado Documento = new XtraRcdNoRadicado(CadenaConexionCartera, XtraFuentePago.StrFuenteRecibo);
                XtraFuentePago.botonpresionado = string.Empty;
                XtraFuentePago.strfuente = string.Empty;
                Documento.ShowDialog();
            }
            else
            {
                XtraFuentePago.botonpresionado = string.Empty;
                XtraFuentePago.strfuente = string.Empty;
            }
            BtnNegociosNoRadicados.Enabled = true;
        }

        private void BtnOtrosi_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnOtrosi.Enabled = false;
            if (MtdValidarFormActiv("XtraModuloOtrosi") == false)
            {
                new XtraModuloOtrosi(CadenaConexionCartera, BtnOtrosi.Tag.ToString())
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnOtrosi.Enabled = true;
        }

        private void BtnPresupuesto_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnPresupuesto.Enabled = false;
            if (MtdValidarFormActiv("XtraAddPresupuesto") == false)
            {
                new XtraAddPresupuesto(CadenaConexionCartera)
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnPresupuesto.Enabled = true;
        }

        private void BtnRadicacion_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnRadicacion.Enabled = false;
            XtraRadicacion Documento = new XtraRadicacion(CadenaConexionCartera);
            Documento.ShowDialog();
            BtnRadicacion.Enabled = true;
        }

        private void BtnRangoCartera_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnRangoCartera.Enabled = false;
            XtraRangoCartera Documento = new XtraRangoCartera(CadenaConexionCartera);
            Documento.ShowDialog();
            BtnRangoCartera.Enabled = true;
        }

        private void BtnRcdJuridicosPdtes_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnRcdJuridicosPdtes.Enabled = false;
            if (MtdValidarFormActiv("XtraCnsRecaudoJuridico") == false)
            {
                new XtraCnsRecaudoJuridico(CadenaConexionCartera)
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnRcdJuridicosPdtes.Enabled = true;
        }

        private void BtnRcdNoRadicadosPdte_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnRcdNoRadicadosPdte.Enabled = false;
            if (MtdValidarFormActiv("XtraCnsRecaudoNoRadicados") == false)
            {
                new XtraCnsRecaudoNoRadicados(CadenaConexionCartera)
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnRcdNoRadicadosPdte.Enabled = true;
        }

        private void BtnRecaudosFecha_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnRecaudosFecha.Enabled = false;
            if (MtdValidarFormActiv("XtraRecaudoFecha") == false)
            {
                new XtraRecaudoFecha(CadenaConexionCartera)
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnRecaudosFecha.Enabled = true;
        }

        private void BtnReservas_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnReservas.Enabled = false;
            if (MtdValidarFormActiv("XtraModuloReservas") == false)
            {
                new XtraModuloReservas(CadenaConexionCartera, BtnReservas.Tag.ToString())
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnReservas.Enabled = true;
        }

        private void BtnSeguimientoCartera_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnSeguimientoCartera.Enabled = false;
            if (MtdValidarFormActiv("XtraSeguimientoPresupuesto") == false)
            {
                new XtraSeguimientoPresupuesto(CadenaConexionCartera)
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnSeguimientoCartera.Enabled = true;
        }

        private void BtnSeguimientoPresupuesto_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnSeguimientoPresupuesto.Enabled = false;
            if (MtdValidarFormActiv("XtraCnsPresupuestoPeriodo") == false)
            {
                new XtraCnsPresupuestoPeriodo(CadenaConexionCartera)
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnSeguimientoPresupuesto.Enabled = true;
        }

        private void BtnSimulador_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnSimulador.Enabled = false;
            if (MtdValidarFormActiv("XtraSimulador") == false)
            {
                new XtraSimulador(CadenaConexionCartera, BtnSimulador.Tag.ToString())
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnSimulador.Enabled = true;
        }

        private void manager_DocumentActivate(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs e)
        {
            PtbImagen.Visible = false;
        }

        private void tabbedView1_DocumentClosed(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs e)
        {
            MtdValidarFormActiv();
        }

        private void BtnPagados_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnPagados.Enabled = false;
            if (MtdValidarFormActiv("XtraPagados") == false)
            {
                new XtraPagados(CadenaConexionCartera)
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnPagados.Enabled = true;
        }

        private void BtnTramiteEscritura_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnTramiteEscritura.Enabled = false;
            if (MtdValidarFormActiv("XtraTramiteEscritura") == false)
            {
                new XtraTramiteEscritura(CadenaConexionCartera)
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnTramiteEscritura.Enabled = true;
        }

        private void BtnEscriturados_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnEscriturados.Enabled = false;
            if (MtdValidarFormActiv("XtraEscriturados") == false)
            {
                new XtraEscriturados(CadenaConexionCartera)
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnEscriturados.Enabled = true;
        }

        private void BtnArchivados_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnArchivados.Enabled = false;
            if (MtdValidarFormActiv("XtraArchivados") == false)
            {
                new XtraArchivados(CadenaConexionCartera)
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnArchivados.Enabled = true;
        }

        private void BtnDestrate_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void BtnDesisitidos_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void BtnDesistidosJuridico_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void BtnParametroOficina_ItemClick(object sender, ItemClickEventArgs e)
        {
            BtnParametroOficina.Enabled = false;
            if (MtdValidarFormActiv("XtraModuloOficina") == false)
            {
                new XtraModuloOficina(CadenaConexionCartera)
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
            BtnParametroOficina.Enabled = true;
        }

        #endregion Modulos de Cartera

        private void BtnSesion_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MtdValidarFormActiv("XtraModuloSesion") == false)
            {
                new XtraModuloSesion(CadenaConexionCartera, BtnSesion.Tag.ToString())
                {
                    MdiParent = this,
                    Text = e.Item.Caption
                }.Show();
            }
        }
    }
}