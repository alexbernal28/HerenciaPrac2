using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Basicos
{
    class CalculoBasic
    {
        private int numero1;
        private int numero2;

        public int Numero1
        {
            get
            {
                return numero1;
            }
            set
            {
                numero1 = value;
            }
        }

        public int Numero2
        {
            get
            {
                return numero2;
            }
            set
            {
                numero2 = value;
            }
        }

        public int Suma(int suma, int suma1)
        {
            this.numero1 = suma;
            this.numero2 = suma1;
            int suma2 = suma + suma1;

            return suma2;
        }
        public int Resta(int resta, int resta1)
        {
            this.numero1 = resta;
            this.numero2 = resta1;
            int resta2 = resta - resta1;

            return resta2;
        }
        public int Multiplication( int multiplicacion, int multiplicacion1)
        {
            this.numero1 = multiplicacion;
            this.numero2 = multiplicacion1;
            int multiplicacion2 = multiplicacion * multiplicacion1;

            return multiplicacion2;
        }
        public int Division(int division, int division1)
        {
            this.numero1 = division;
            this.numero2 = division1;
            int division2 = division / division1;

            return division2;
        }
    }
}
