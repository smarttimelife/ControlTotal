
using System;

namespace ModelCartera
{
    public class simulador : baseViewModel
    {
        private DateTime fecha;
        private DateTime fechaFnc;
        private DateTime fechaExtra;
        private string cliente;
        private decimal prestamo;
        private decimal cuotaInicial;
        private decimal financiacion;
        private decimal extraordinaria;
        private decimal cuotaFnc;
        private decimal cuotaExtra;
        private decimal saldoFinanciar;
        private decimal porcentaje;
        private decimal tasa;
        private int plazoExtra;
        private int plazoFnc;
        private int periodoFnc;
        private int periodoExtra;
        private int formaPago;
        public decimal Cuota { get; set; }
        public decimal Capital { get; set; }
        public decimal Interes { get; set; }
        public string Concepto { get; set; }
        public int CuotaNumero { get; set; }
        public DateTime Fecha
        {
            get { return fecha; }
            set { SetValue(ref fecha, value); }
        }
        public DateTime FechaFnc
        {
            get { return fechaFnc; }
            set { SetValue(ref fechaFnc, value); }
        }

        public DateTime FechaExtra
        {
            get { return fechaExtra; }
            set { SetValue(ref fechaExtra, value); }
        }
        public string Cliente
        {
            get { return cliente; }
            set { SetValue(ref cliente, value); }
        }
        public decimal Prestamo
        {
            get { return prestamo; }
            set { SetValue(ref prestamo, value); }
        }
        public decimal CuotaInicial
        {
            get { return cuotaInicial; }
            set { SetValue(ref cuotaInicial, value); }
        }
        public decimal Financiacion
        {
            get { return (prestamo - cuotaInicial - extraordinaria); }
            set { SetValue(ref financiacion, value); }
        }
        public decimal Extraordinaria
        {
            get { return extraordinaria; }
            set { SetValue(ref extraordinaria, value); }
        }
        public decimal CuotaFnc
        {
            get { return cuotaFnc; }
            set { SetValue(ref cuotaFnc, value); }
        }
        public decimal SaldoFinanciar
        {
            get { return (prestamo - cuotaInicial); }
            set { SetValue(ref saldoFinanciar, value); }
        }
        public decimal CuotaExtra
        {
            get { return cuotaExtra; }
            set { SetValue(ref cuotaExtra, value); }

        }
        public decimal Tasa
        {
            get { return tasa; }
            set { SetValue(ref tasa, value); }

        }
        public decimal Porcentaje
        {
            get { return porcentaje; }
            set { SetValue(ref porcentaje, value); }

        }
        public int PlazoExtra
        {
            get { return plazoExtra; }
            set { SetValue(ref plazoExtra, value); }

        }
        public int PlazoFnc
        {
            get { return plazoFnc; }
            set { SetValue(ref plazoFnc, value); }

        }
        public int PeriodoFnc
        {
            get { return periodoFnc; }
            set { SetValue(ref periodoFnc, value); }

        }
        public int PeriodoExtra
        {
            get { return periodoExtra; }
            set { SetValue(ref periodoExtra, value); }

        }
        public int FormaPago
        {
            get { return formaPago; }
            set { SetValue(ref formaPago, value); }

        }


    }
}
