namespace NegociosCartera
{
    #region Librerias
    using Conexiones;
    using Microsoft.EntityFrameworkCore;
    using ModelCartera;
    using System;
    using System.Data;
    //JAVIER ENRIQUE VILLALBA ESPINOSA
    //ABRIL 20 2020
    #endregion
    public class negSimulador : NegConsultasCartera
    {
        public simulador EntSimulador = new simulador();
        private DbSet<oficina> oficina { get; set; }
        private oficina EntOficina = new oficina();

        public event DlgtDataTableExit DataError_Event_simulador;

        public negSimulador(CadenaConexionMysql cadenasConexion) : base(cadenasConexion)
        {
            EntOficina = oficina.Find(1);
            EntSimulador.Tasa = EntOficina.IntCorriente;
            EntSimulador.Porcentaje = EntOficina.Porcentaje;
            EntSimulador.Fecha = DateTime.Now;
            EntSimulador.PeriodoExtra = 180;
            EntSimulador.PeriodoFnc = 30;
        }

        #region Metodos

        public void CuotaFija()
        {
            double tasa = Convert.ToDouble(EntSimulador.Tasa);
            double financiacion = Convert.ToDouble(EntSimulador.Financiacion);
            int periodo = EntSimulador.PeriodoFnc;
            int plazo = EntSimulador.PlazoFnc;

            if (EntSimulador.Financiacion > 0 & EntSimulador.PlazoFnc > 0 & EntSimulador.PeriodoFnc > 0)
            {
                EntSimulador.CuotaFnc = MtdCalculoCuota(financiacion, tasa, periodo, plazo);
            }
            else
                EntSimulador.CuotaFnc = 0;
        }
        public void Extraordinaria()
        {
            double tasa = Convert.ToDouble(EntSimulador.Tasa);
            double cuotaExtra = Convert.ToDouble(EntSimulador.CuotaExtra);
            int periodo = EntSimulador.PeriodoExtra;
            int plazo = EntSimulador.PlazoExtra;

            if (EntSimulador.CuotaExtra > 0 & EntSimulador.PlazoExtra > 0 & EntSimulador.PeriodoExtra > 0)
            {
                EntSimulador.Extraordinaria = MtdCalcularCapital(cuotaExtra, plazo, tasa, periodo);
            }
            else
                EntSimulador.Extraordinaria = 0;
        }
        public DataTable DtCuotas()
        {
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            MtdValidar();

            if (CuentaErrores > 0)
            {
                DataError_Event_simulador(Stb.ToString(), dt2);
            }
            else
            {
                double tasa = Convert.ToDouble(EntSimulador.Tasa);
                double financiacion = Convert.ToDouble(EntSimulador.Financiacion);
                int periodofnc = EntSimulador.PeriodoFnc;
                int plazofnc = EntSimulador.PlazoFnc;
                string CtoFnc = string.Empty, CtoExtra = string.Empty;
                if (EntSimulador.FormaPago == 1)
                {
                    CtoFnc = "Fn";
                    CtoExtra = "Ex";
                }
                else
                {
                    CtoFnc = "Ex";
                    CtoExtra = "Fn";
                }

                if (EntSimulador.Financiacion > 0 & EntSimulador.PlazoFnc > 0 & EntSimulador.PeriodoFnc > 0)
                {
                    dt = MtdCuotas(tasa, plazofnc, financiacion, periodofnc, EntSimulador.FechaFnc, CtoFnc, "0");
                }

                int periodoextra = EntSimulador.PeriodoExtra;
                int plazoextra = EntSimulador.PlazoExtra;
                double extraordinaria = Convert.ToDouble(EntSimulador.Extraordinaria);

                if (EntSimulador.Extraordinaria > 0 & EntSimulador.PlazoExtra > 0 & EntSimulador.PeriodoExtra > 0)
                {
                    dt1 = MtdCuotas(tasa, plazoextra, extraordinaria, periodoextra, EntSimulador.FechaExtra, CtoExtra, "0");
                }

                dt2 = dt.Copy();
                dt2.Merge(dt1);
            }
            return dt2;
        }
        private void MtdValidar()
        {
            Stb.Clear();
            CuentaErrores = 0;

            if ((EntSimulador.FormaPago == 1) & (EntSimulador.CuotaFnc == 0))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Cuotas Financiacion");
            }

            if ((EntSimulador.FormaPago == 1) & (EntSimulador.PeriodoFnc == 0))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Periodo");
            }
            if ((EntSimulador.FormaPago == 1) & (EntSimulador.PlazoFnc == 0))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Numero Cuotas Fnc");
            }
            if ((EntSimulador.FormaPago == 2) & (EntSimulador.CuotaExtra == 0))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Cuotas Extra");
            }
            if ((EntSimulador.FormaPago == 2) & (EntSimulador.PlazoExtra == 0))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Numero de Cuotas Extras");
            }

            if ((EntSimulador.FormaPago == 2) & (EntSimulador.FechaExtra == null || EntSimulador.FechaExtra == Convert.ToDateTime("1/01/0001")))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Fecha Extra");
            }
            if (EntSimulador.FechaFnc == null || EntSimulador.FechaFnc == Convert.ToDateTime("1/01/0001"))
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Fecha Financiacion");
            }
            if ((EntSimulador.Prestamo - EntSimulador.CuotaInicial - EntSimulador.Financiacion - EntSimulador.Extraordinaria) != 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Documento Descuadrado");
            }
        }
        public void MtdLimpiar()
        {
            EntSimulador = new simulador();
            EntSimulador.Fecha = DateTime.Now;
            EntSimulador.PeriodoExtra = 180;
            EntSimulador.PeriodoFnc = 30;
            EntOficina = oficina.Find(1);
            EntSimulador.Tasa = EntOficina.IntCorriente;
            EntSimulador.Porcentaje = EntOficina.Porcentaje;
        }

        public DataTable MtdCuotaFija()
        {
            MtdValidarCuotas();
            DataTable dt2 = new DataTable();

            if (CuentaErrores > 0)
            {
                DataError_Event_simulador(Stb.ToString(), dt2);
                return dt2;
            }
            else
            return ConsultaCuotasFija(EntSimulador.Capital, EntSimulador.Tasa, EntSimulador.PlazoFnc, EntSimulador.Concepto, EntSimulador.PeriodoFnc, EntSimulador.FechaFnc) ;

        }

        private void MtdValidarCuotas()
        {
            Stb.Clear();
            CuentaErrores = 0;

            if (String.IsNullOrEmpty( EntSimulador.Concepto))
            {
                EntSimulador.Concepto = "FN";
            }

            if (EntSimulador.PeriodoFnc == 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Periodo");
            }
            if (EntSimulador.Capital == 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Valor");
            }

            if (EntSimulador.PlazoFnc == 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Plazo ");
            }

            if (EntSimulador.Tasa == 0)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Tasa ");
            }
            if ( EntSimulador.FechaFnc == Convert.ToDateTime("1/01/0001")|| EntSimulador.FechaFnc==null)
            {
                CuentaErrores += 1;
                Stb.AppendLine("Falta Fecha ");
            }
           
        }
        #endregion
    }
}