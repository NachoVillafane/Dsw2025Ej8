using System;
using Dsw2025Ej8.Domain;

class Program
{
    static void Main()
    {
        
        string[] titulares1 = { "Aylen" };
        string[] titulares2 = { "Ignacio" };
        string[] titulares3 = { "Leandro" };
        string[] titulares4 = { "Paulina" };

        
        var caja1 = new CajaDeAhorro("CA001", 1000, titulares1) { TasaDeInteres = 0.05m };
        var caja2 = new CajaDeAhorro("CA002", 200, titulares2) { TasaDeInteres = 0.04m };

        var corriente1 = new CuentaCorriente("CC001", 500, titulares3)
        {
            Comision = 0.01m,
            LimiteDeDescubierto = 100
        };

        var corriente2 = new CuentaCorriente("CC002", 300, titulares4)
        {
            Comision = 0.02m,
            LimiteDeDescubierto = 200
        };

        
        caja1.Depositar(100);
        caja1.AplicarInteres();
        caja1.Retirar(50);

        corriente1.Depositar(200);
        corriente1.Retirar(700); 

        
        MostrarCuenta(caja1);
        MostrarCuenta(caja2);
        MostrarCuenta(corriente1);
        MostrarCuenta(corriente2);

        
        ProbarOperacion(() => caja2.Depositar(-100), "Caja2: Depositar -100 (MontoNoValido)");
        ProbarOperacion(() => corriente2.Retirar(600), "Corriente2: Retiro excesivo (SaldoInsuficiente)");
        corriente2.CambiarEstado(Estado.Inactiva);
        ProbarOperacion(() => corriente2.Depositar(50), "Corriente2: Operación con cuenta inactiva");
    }

    static void MostrarCuenta(CuentaBancaria cuenta)
    {
        Console.WriteLine($"Cuenta {cuenta.Numero} ({cuenta.GetType().Name})");
        Console.WriteLine($" - Titular/es: {string.Join(", ", cuenta.Titulares)}");
        Console.WriteLine($" - Saldo: {cuenta.Saldo}");
        Console.WriteLine($" - Estado: {cuenta.Estado}");
        Console.WriteLine();
    }

    static void ProbarOperacion(Action operacion, string descripcion)
    {
        Console.WriteLine($"Intentando: {descripcion}");
        try
        {
            operacion();
            Console.WriteLine("Operacion exitosa\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Excepcion: {ex.Message}\n");
        }
    }



}