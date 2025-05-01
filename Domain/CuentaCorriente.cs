using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dsw2025Ej8.Domain.Excepciones;

namespace Dsw2025Ej8.Domain
{
    public class CuentaCorriente : CuentaBancaria
    {
        public CuentaCorriente(string numero, decimal saldo, string[] titulares)
            : base(numero, saldo, titulares)
        {
        }

        public override void Depositar(decimal monto)
        {
            VerificarMontoValido(monto);  
            VerificarCuentaActiva();      

            monto -= monto * Comision; 
            Saldo += monto; 
        }

        public override void Retirar(decimal monto)
        {
            VerificarMontoValido(monto);  
            VerificarCuentaActiva();      

            if (Saldo - monto >= -LimiteDeDescubierto) 
            {
                Saldo -= monto; 

                if (Saldo < 0)
                {
                    Estado = Estado.Suspendida; 
                }
            }
            else
            {
                throw new SaldoInsuficiente("La cuenta no cuenta con saldo para la operación solicitada. Fue suspendida.");
            }
        }

        public override void AplicarInteres()
        {
           
        }
    }
}