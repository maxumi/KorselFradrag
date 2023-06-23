using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Befordring
{
    public class AbstractKorselsFradrag
    {
        private const double IkkeBetaltKm = 24;
        private const double KrPerKm = 2.19;
        private const double KrPerKmOver120 = 1.10;
        private const double Procent = 0.26;
        private readonly double _kms;

        public AbstractKorselsFradrag(double Kms)
        {
            _kms = Kms;
        }
        virtual public double ReturnMath()
        {
            return 0;
        }
        virtual public double ReturnQA(int Anwsr)
        {
            return 0;
        }
    }
}
