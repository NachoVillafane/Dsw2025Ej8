using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    internal class Excepciones
    {
        public class MontoNoValido : Exception
        {
            public MontoNoValido(string mensaje) : base(mensaje) { }
        }

        public class CuentaNoActiva : Exception
        {
            public CuentaNoActiva(string mensaje) : base(mensaje) { }
        }

        public class SaldoInsuficiente : Exception
        {
            public SaldoInsuficiente(string mensaje) : base(mensaje) { }
        }
    }
}
