using Conexiones;
using ModelCartera;
using NegociosCartera;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Cartera
{
    public class negDocumentacion: NegConsultasCartera
    {
        #region Propiedades
        private CadenaConexionMysql CadenaConexion;
        public datosconsulta EntDatosConsultas = new datosconsulta();
        public documentacion EntDocumentacion = new documentacion();
        public event DlgtStringExit Ok_Event_String_negDocumentacion;
        public event DlgtStringExit Error_Event_String_NegDocumentacion;
        private string StrOperacion = string.Empty;
        private string StrIdAdjudicacion = string.Empty;
        
        #endregion

        #region Constructor
        public negDocumentacion(CadenaConexionMysql cadenaConexion,string strIdAdjudicacion,string strOperacion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            StrIdAdjudicacion = strIdAdjudicacion;
            StrOperacion = strOperacion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
        }

        public negDocumentacion(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;      
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
        }
        #endregion

        #region Disparadores
        private void ConexionMysql_EventOkStringMysql(string mensaje)
        {
            Ok_Event_String_negDocumentacion(mensaje  +" La Adjudicacion Cambio a Estado "+StrOperacion);
        }

        private void ConexionMysql_EventErrorStringMysql(string mensaje)
        {
            Error_Event_String_NegDocumentacion(mensaje);
        }
        #endregion


        #region Metodos

       public void MtdEnviar()
        {
            if (string.IsNullOrEmpty(EntDocumentacion.ComentariosEnvio))
            {
                Error_Event_String_NegDocumentacion("Falta Comentario");
            }
            else
            {
                try
                {
                    EntDocumentacion.Fecha = DateTime.Now;
                    EntDocumentacion.Estado = "Enviado";
                    EntDocumentacion.IdAdjudicacion = StrIdAdjudicacion;
                    EntDocumentacion.Operacion = StrOperacion;
                    EntDocumentacion.UsuarioEnvio = CadenaConexion.Logeo.Usuario;
                    EntDocumentacion.UsuarioRecibe = "Pendiente";
                    string[] consulta = new string[2];
                    string resultado = string.Empty;
                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntDocumentacion));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntDocumentacion));
                    consulta[0] = CadenaConexion.mtdCrearInsert("documentacion", CadenaConexion.MtdCrearParametro(EntDocumentacion));

                    string[] nompara={ "Estado","IdAdjudicacion"};
                    object[] valpara={ StrOperacion,StrIdAdjudicacion};
                    nomparametros.Add(nompara);
                    valparametros.Add(valpara);
                    consulta[1] = "Update adjudicacion set Estado=@Estado,Documentacion='Enviada' Where IdAdjudicacion=@IdAdjudicacion";
                    resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception Ex)
                {
                    Error_Event_String_NegDocumentacion(Ex.Message);
                }
            }
        }

       public void MtdBuscarDocumento()
        {
            string[] StrParametro = { "Operacion","IdAdjudicacion" };
            object[] ObjParametro = { StrOperacion, StrIdAdjudicacion };
            string  StrConsulta = "Select * from documentacion Where IdAdjudicacion=@IdAdjudicacion and Operacion=@Operacion and UsuarioRecibe='Pendiente'";
            DataTable Dt = ConexionMysql.MtdDataTableReaderText(StrConsulta, StrParametro, ObjParametro);
            if (Dt.Rows.Count == 1)
            {
                documentacion docm = new documentacion
                {
                    Id =Convert.ToInt32( Dt.Rows[0]["Id"]),
                    Fecha=Convert.ToDateTime(Dt.Rows[0]["Fecha"]),
                    IdAdjudicacion=Dt.Rows[0]["IdAdjudicacion"].ToString(),
                    UsuarioEnvio=Dt.Rows[0]["UsuarioEnvio"].ToString(),
                    ComentariosEnvio= Dt.Rows[0]["ComentariosEnvio"].ToString(),
                    Operacion= Dt.Rows[0]["Operacion"].ToString(),

                };
                EntDocumentacion = docm;
            }
            else
            {
                Error_Event_String_NegDocumentacion("Error Aplicacion en consuta MtdBucarDocumento");
            }
               
        }


        public void MtdAceptar()
        {
            if (string.IsNullOrEmpty(EntDocumentacion.ComentariosRecibe))
            {
                Error_Event_String_NegDocumentacion("Falta Comentario");
            }
            else
            {
                try
                {
                    EntDocumentacion.FechaRecibe = DateTime.Now;
                    EntDocumentacion.Estado = "Recibido";
                    EntDocumentacion.IdAdjudicacion = StrIdAdjudicacion;  
                    EntDocumentacion.UsuarioRecibe = CadenaConexion.Logeo.Usuario;
                    string[] consulta = new string[2];
                    string resultado = string.Empty;
                    string[] strWhere = { "Id" };
                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntDocumentacion));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntDocumentacion));
                    consulta[0] = CadenaConexion.mtdCrearUpdate("documentacion", CadenaConexion.MtdCrearParametro(EntDocumentacion),strWhere);

                    string[] nompara = { "Estado", "IdAdjudicacion" };
                    object[] valpara = { StrOperacion, StrIdAdjudicacion };
                    nomparametros.Add(nompara);
                    valparametros.Add(valpara);
                    consulta[1] = "Update adjudicacion set Documentacion='Recibido' Where IdAdjudicacion=@IdAdjudicacion";
                    resultado = ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (Exception Ex)
                {
                    Error_Event_String_NegDocumentacion(Ex.Message);
                }
            }
        }
        #endregion

    }
}
