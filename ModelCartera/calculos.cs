using System;

namespace ModelCartera
{
    public class calculos : baseViewModel
    {
        private decimal capital;
        private decimal cuota;
        private decimal tasa;
        private int plazo;
        private int periodo;
        private DateTime fecha;
        private int decimales;
        public DateTime Fecha
        {
            get { return fecha; }
            set { SetValue(ref fecha, value); }
        }

        public decimal Capital
        {
            get { return capital; }
            set { SetValue(ref capital, value); }
        }
        public decimal Tasa
        {
            get { return tasa; }
            set { SetValue(ref tasa, value); }
        }
        public decimal Cuota
        {
            get { return cuota; }
            set { SetValue(ref cuota, value); }
        }
        public int Plazo
        {
            get { return plazo; }
            set { SetValue(ref plazo, value); }
        }
        public int Periodo
        {
            get { return periodo; }
            set { SetValue(ref periodo, value); }
        }
        public int Decimales
        {
            get { return decimales; }
            set { SetValue(ref decimales, value); }
        }

    }
}
