# Ejercicio N� 8
## Desarrollo de Software
### Herencia y propiedades

1. Realizar una bifurcaci�n (fork) del [repositorio](https://github.com/ing-software-frt-utn/dsw2025ej8)
2. Crear una rama de larga duraci�n development
3. Clonar el repositorio bifurcado y trabajar sobre la rama development
4. Refactorizar el c�digo aplicando herencia seg�n el caso
5. Reemplazar los m�todos getters y setters, y campos por propiedades, tener en cuenta la accesibilidad en cada caso
6. Respetar que al crear una cuenta bancaria se reciba el n�mero y el saldo en el constructor
7. La tasa de inter�s se debe indicar al inicializar la instancia de cuenta, pero no mediante el constructor
8. El l�mite de descubierto se debe indicar al inicializar la instancia de cuenta, pero no mediante el constructor
9. Agregar las siguientes reglas:
	* El monto recibido por cualquier operaci�n no puede ser menor o igual a 0, de lo contrario generar una excepci�n del tipo MontoNoValido
	* Cualquier operaci�n se debe realizar si la cuenta est� activa, en cualquier otro caso generar una excepci�n del tipo CuentaNoActiva
	* Se debe contar con saldo para realizar un retiro, caso contrario debe generar una excepci�n SaldoInsuficiente y la cuenta debe quedar suspendida. Tener en cuenta el l�mite de descubierto si corresponde
10. Instanciar 4 cuentas (dos de cada tipo) y realizar diferentes operaciones que permitan comprobar todas las funciones posibles.
11. Recorrer las 4 cuentas creadas y mostrar por consola un resumen de cada una, que incluya n�mero, tipo y saldo (utilizar una clase an�nima)

Consideraciones:
- Las excepciones deben incluir los siguiente mensajes:
- MontoNoValido -> El monto ingresado no es v�lido para la operaci�n solicitada
- CuentaNoActiva -> No se puede operar con la cuenta {estado} (reemplazar por el estado en el que se encuentra)
- SaldoInsuficiente -> La cuenta no cuenta con saldo para la operaci�n solicitada. Fue suspendida.
- La aplicaci�n no debe interrumpir su funcionamiento si se produce una excepci�n.
