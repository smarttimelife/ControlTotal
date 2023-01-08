using ModelCartera;
using System;
using System.Data;

namespace NegociosCartera
{
    public delegate void DlgtDataTableExit(string mensaje, DataTable dataTable);

    public class negCalculos
    {
        public calculos EntCalculos = new calculos();
        public DlgtDataTableExit Event_ErrorTableNgConsultas;

        public negCalculos()
        {
            EntCalculos.Fecha = DateTime.Now;
            EntCalculos.Periodo = 30;
            EntCalculos.Tasa = 18;
        }

        public DataTable DtPeriodo()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Periodo", typeof(int));
            dt.Rows.Add("Mensual", 30);
            dt.Rows.Add("Bimensual", 60);
            dt.Rows.Add("Trimestral", 90);
            dt.Rows.Add("Cuatrimestral", 120);
            dt.Rows.Add("Semestral", 180);
            dt.Rows.Add("Anual", 360);

            return dt;
        }

        public decimal Cuota()
        {
            double tasa = Convert.ToDouble(EntCalculos.Tasa);
            double financiacion = Convert.ToDouble(EntCalculos.Capital);
            int periodo = EntCalculos.Periodo;
            int plazo = EntCalculos.Plazo;

            if (EntCalculos.Capital > 0 & EntCalculos.Plazo > 0 & EntCalculos.Periodo > 0)
            {
                EntCalculos.Cuota = MtdCalculoCuota(financiacion, tasa, periodo, plazo);
            }
            else
                EntCalculos.Cuota = 0;
            return EntCalculos.Cuota;
        }

        public decimal Capital()
        {
            double tasa = Convert.ToDouble(EntCalculos.Tasa);
            double cuotaExtra = Convert.ToDouble(EntCalculos.Cuota);
            int periodo = EntCalculos.Periodo;
            int plazo = EntCalculos.Plazo;

            if (EntCalculos.Cuota > 0 & EntCalculos.Plazo > 0 & EntCalculos.Periodo > 0)
            {
                EntCalculos.Capital = MtdCalcularCapital(cuotaExtra, plazo, tasa, periodo);
            }
            else
                EntCalculos.Capital = 0;
            return EntCalculos.Capital;
        }

        public decimal MtdCalculoCuota(double Valor, double Tasa, int Periodo, int Plazo)
        {
            double CuotaFijaCalculada;
            double PeriodoC = Periodo;
            DataTable table = new DataTable();

            if (Plazo == 0)
            {
                Event_ErrorTableNgConsultas("Plazo No Puede ser 0", table);
                return 0;
            }
            else
            {
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
                        CuotaFijaCalculada = Math.Round((Valor / Plazo), 0);
                    }
                    return Convert.ToDecimal(Math.Round(CuotaFijaCalculada, 0));
                }
                catch (Exception ex)
                {
                    Event_ErrorTableNgConsultas(ex.Message, table);
                    return 0;
                }
            }
        }

        public decimal MtdCalcularCapital(double Cuota, double Plazo, double TasaInteres, int Periodo)
        {
            double Capital;
            Periodo = (30 / Periodo) * 12;
            double a, b, x;
            a = (1 + TasaInteres / (Periodo * 100));
            b = Plazo;
            x = Math.Pow(a, b);
            x = 1 / x;
            x = 1 - x;
            Capital = (Cuota) / (TasaInteres / (Periodo * 100)) * x;
            return Convert.ToDecimal(Math.Round(Capital, 0));
        }
    }
}