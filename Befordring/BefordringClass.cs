using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Befordring
{
    public class BefordringClass
    {
        private const double IkkeBetaltKm = 24;
        private const double KrPerKm = 2.1;
        private const double KrPerKmOver120 = 1.1;
        private const double Procent = 0.26;
        private readonly double _kms;

        public BefordringClass(double Kms)
        {
            _kms = Kms;
        }
        public double ReturnMath()
        {
            if ( _kms <= 24)
            {
                return 0;
            }
            else if ( _kms >= 25 && _kms <= 120)
            {
                double kms = 0;

                kms -= IkkeBetaltKm;
                kms = _kms * KrPerKm;
                kms = _kms * Procent;

                return Math.Round(kms, 4);
            }
            else if (_kms > 120)
            {
                double First120 = (120 - IkkeBetaltKm) * KrPerKm * Procent;  // Hvis man ved at de første 120 er altid 52,416 kr så behoves det ikke kms.
                double Above120 = (_kms - 120) * KrPerKmOver120 * Procent;  // fjerner de første 120 og giver

                return Math.Round(First120 + Above120,4);
            }
            else
            {
                return 0;
            }
        }
        public double ReturnQA(int Anwsr)
        {
            double fraDrag = ReturnMath();
            switch (Anwsr)
            {
                case 1:

                    fraDrag += 110;
                    break;
                case 2:
                    fraDrag += 15;
                    break;
                case 3:
                    fraDrag += 50;
                    break;
                case 4:
                    fraDrag += 8;
                    break;
                case 5:
                    break;
                default:
                    break;
            }
            return Math.Round(fraDrag,4);
        }
    }
}
