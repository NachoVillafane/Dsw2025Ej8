using static Dsw2025Ej8.Domain.Excepciones;

namespace Dsw2025Ej8.Domain
{
    public abstract class CuentaBancaria
    {
        
        public string Numero { get; private set; }
        public decimal Saldo { get; protected set; }
        public Estado Estado { get; protected set; }
        public decimal TasaDeInteres { get; set; }
        public decimal LimiteDeDescubierto { get; set; }
        public decimal Comision { get; set; }
        public string[] Titulares { get; private set; }

        
        public CuentaBancaria(string numero, decimal saldo, string[] titulares)
        {
            Numero = numero;
            Saldo = saldo;
            Estado = Estado.Activa;  
            Titulares = titulares;
        }

     
        public abstract void Depositar(decimal monto);
        public abstract void Retirar(decimal monto);
        public abstract void AplicarInteres();

       
        protected void VerificarMontoValido(decimal monto)
        {
            if (monto <= 0)
            {
                throw new MontoNoValido("El monto ingresado no es valido para la operacion solicitada");
            }
        }

        protected void VerificarCuentaActiva()
        {
            if (Estado != Estado.Activa)
            {
                throw new CuentaNoActiva($"No se puede operar con la cuenta {Estado}.");
            }
        }
        public void CambiarEstado(Estado nuevoEstado)
        {
            Estado = nuevoEstado;
        }
    }
}