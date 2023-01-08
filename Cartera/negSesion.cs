namespace Cartera
{
    #region Librerias
    using Conexiones;
    using ModelCartera;
    using NegociosCartera;
    using System.Collections.Generic;
    #endregion Librerias
    public class negSesion : NegConsultasCartera
    {
        #region Propiedades
        public sesion EntSesion = new sesion();
        public List<ViewAdjSesion> LstAdjSesion = new List<ViewAdjSesion>();
        public event DlgtStringExit OkString_Event_sesion;
        public event DlgtStringExit ErrorString_Event_sesion;
        private CadenaConexionMysql CadenaConexion;
        public adjudicacion EntAdjudicacion = new adjudicacion();
        #endregion

        public negSesion(CadenaConexionMysql cadenaConexion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            LstAdjSesion = ConexionMysql.ConvertDataTable<ViewAdjSesion>(CnsDtConsulta("AdjSesion"));
        }

        public negSesion(CadenaConexionMysql cadenaConexion,string IdSesion) : base(cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
            ConexionMysql.EventErrorStringMysql += ConexionMysql_EventErrorStringMysql;
            ConexionMysql.EventOkStringMysql += ConexionMysql_EventOkStringMysql;
            List<sesion> Lista = ConexionMysql.MtdLista<sesion>("Select * from  sesion Where IdSesion=@IdSesion", "IdSesion", IdSesion);
            EntSesion= Lista[0];
            LstAdjSesion = ConexionMysql.ConvertDataTable<ViewAdjSesion>(CnsDtConsulta("AdjSesionTodos"));
        }

        private void ConexionMysql_EventOkStringMysql(string mensaje)
        {
            OkString_Event_sesion(mensaje);
        }

        private void ConexionMysql_EventErrorStringMysql(string mensaje)
        {
            ErrorString_Event_sesion(mensaje);
        }

        

        public void MtdAdicionar()
        {
            MtdValidar();
            if (Stb.Length > 0)
            {
                ErrorString_Event_sesion(Stb.ToString());
            }
            else
            {
                try
                {
                    string[] consulta = new string[2];
                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };

                    string[] Para = { "IdAdjudicacion" };
                    object[] ObPara = { EntSesion.IdAdjudicacion };
                    consulta[0] = "Update adjudicacion set estado='Sesion' Where IdAdjudicacion=@IdAdjudicacion";
                    nomparametros.Add(Para);
                    valparametros.Add(ObPara);

                    EntSesion.Estado = "Pendiente";
                    EntSesion.UsuarioElabora = CadenaConexion.Logeo.Usuario;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntSesion));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntSesion));
                    consulta[1] = CadenaConexion.mtdCrearInsert("sesion", CadenaConexion.MtdCrearParametro(EntSesion));
                    ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (System.Exception e)
                {
                    ErrorString_Event_sesion(e.Message);
                }
            }
        }

        public void MtdModificar()
        {
            MtdValidar();
            if (Stb.Length > 0)
            {
                ErrorString_Event_sesion(Stb.ToString());
            }
            else
            {
                try
                {
                    string[] consulta = new string[1];
                    List<string[]> nomparametros = new List<string[]> { };
                    List<object[]> valparametros = new List<object[]> { };

                   
                    EntSesion.Estado = "Pendiente";
                    string[] Par = { "IdSesion" };
                    EntSesion.UsuarioElabora = CadenaConexion.Logeo.Usuario;
                    nomparametros.Add(CadenaConexion.MtdCrearParametro(EntSesion));
                    valparametros.Add(CadenaConexion.MtdValParametros(EntSesion));
                    consulta[0] = CadenaConexion.mtdCrearUpdate("sesion", CadenaConexion.MtdCrearParametro(EntSesion),Par);
                    ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
                }
                catch (System.Exception e)
                {
                    ErrorString_Event_sesion(e.Message);
                }
            }
        }

        public void MtdAprobar()
        {
            try
            {
                string[] Nomparametros = { "IdSesion" };
                object[] Valparametros = { EntSesion.IdSesion };

                string sentencia = "Update Adjudicacion Set IdTercero1=@IdTercero1,IdTercero2=@IdTercero2, IdTercero3=@IdTercero3, Estado='Aprobado' Where IdAdjudicacion=@IdAdjudicacion";
                string Sentencia2 = "Update Sesion Set Estado='Aprobado' Where IdSesion=@IdSesion";

                string[] consulta = new string[2];
                List<string[]> nomparametros = new List<string[]> { };
                List<object[]> valparametros = new List<object[]> { };

                string[] Nomparametros1 = { "IdTercero1", "IdTercero2", "IdTercero3", "IdAdjudicacion" };
                object[] Valparametros1 = { EntSesion.NuevoIdTercero1, EntSesion.NuevoIdTercero2, EntSesion.NuevoIdTercero3, EntSesion.IdAdjudicacion };

                nomparametros.Add(Nomparametros1);
                valparametros.Add(Valparametros1);
                consulta[0] = sentencia;

                nomparametros.Add(Nomparametros);
                valparametros.Add(Valparametros);
                consulta[1] = Sentencia2;
                ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
            }
            catch (System.Exception e)
            {
                ErrorString_Event_sesion(e.Message);                
            }
        }

        public void MtdEliminar()
        {
            try
            {
                string[] Nomparametros = { "IdSesion" };
                object[] Valparametros = { EntSesion.IdSesion };

                string sentencia = "Update Adjudicacion Set Estado='Aprobado' Where IdAdjudicacion=@IdAdjudicacion";
                string Sentencia2 = "Update Sesion Set Estado='Eliminado' Where IdSesion=@IdSesion";

                string[] consulta = new string[2];
                List<string[]> nomparametros = new List<string[]> { };
                List<object[]> valparametros = new List<object[]> { };

                string[] Nomparametros1 = {  "IdAdjudicacion" };
                object[] Valparametros1 = {  EntSesion.IdAdjudicacion };

                nomparametros.Add(Nomparametros1);
                valparametros.Add(Valparametros1);
                consulta[0] = sentencia;

                nomparametros.Add(Nomparametros);
                valparametros.Add(Valparametros);
                consulta[1] = Sentencia2;
                ConexionMysql.MtdEjecutarText(consulta, nomparametros, valparametros);
            }
            catch (System.Exception e)
            {
                ErrorString_Event_sesion(e.Message);
            }
        }

        private void MtdValidar()
        {
            Stb.Clear();           

            if (string.IsNullOrEmpty(EntSesion.IdAdjudicacion))
            {
                Stb.AppendLine("Falta Adjudicacion");                
            }
            if (string.IsNullOrEmpty(EntSesion.IdTercero1))
            {
                Stb.AppendLine("Falta Titular");
            }
            if (string.IsNullOrEmpty(EntSesion.NuevoIdTercero1))
            {
                Stb.AppendLine("Falta Nuevo Titular");
            }
        }
    }
}
