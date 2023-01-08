using ModelCartera;
using System;
using System.Data;

namespace ControlTotal
{
    public delegate void DlgtDataTableExit(string mensaje, DataTable dataTable);

    public delegate void DlgteGoogleDrive(string mensaje, googledrivefile googledoc);

    public delegate void DlgteString(string mensaje);

    public class OperCalculos
    {
        public calculos EntCalculos = new calculos();
        public DlgtDataTableExit Event_ErrorTableNgConsultas;

        public OperCalculos()
        {
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
            double capital = Convert.ToDouble(EntCalculos.Capital);
            int periodo = EntCalculos.Periodo;
            int plazo = EntCalculos.Plazo;
            int decim = EntCalculos.Decimales;
            decimal cuota = 0;
            if (EntCalculos.Capital > 0 & EntCalculos.Plazo > 0 & EntCalculos.Periodo > 0)
            {
                cuota = MtdCalculoCuota(capital, tasa, periodo, plazo, decim);
            }
            else
            {
                cuota = 0;
            }

            return cuota;
        }

        public decimal Capital()
        {
            double tasa = Convert.ToDouble(EntCalculos.Tasa);
            double cuota = Convert.ToDouble(EntCalculos.Cuota);
            double periodo = Convert.ToDouble(EntCalculos.Periodo);
            int plazo = EntCalculos.Plazo;
            int decim = EntCalculos.Decimales;
            decimal capital = 0;
            if (EntCalculos.Cuota > 0 & EntCalculos.Plazo > 0 & EntCalculos.Periodo > 0)
            {
                capital = MtdCalcularCapital(cuota, plazo, tasa, periodo, decim);
            }
            else
            {
                capital = 0;
            }

            return capital;
        }

        private decimal MtdCalculoCuota(double Valor, double Tasa, int Periodo, int Plazo, int dec)
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
                        CuotaFijaCalculada = Math.Round((Valor / Plazo), dec);
                    }
                    return Convert.ToDecimal(Math.Round(CuotaFijaCalculada, dec));
                }
                catch (Exception ex)
                {
                    Event_ErrorTableNgConsultas(ex.Message, table);
                    return 0;
                }
            }
        }

        private decimal MtdCalcularCapital(double Cuota, double Plazo, double TasaInteres, double Periodo, int dec)
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
            return Convert.ToDecimal(Math.Round(Capital, dec));
        }
    }
}