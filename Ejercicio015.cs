/*
Ejercicio 015
Desarrollar un programa que permita el cálculo del valor de π/4 por medio de una fracción
continua. El usuario debe ingresar el número de fracciones a realizar, entre mayor sea el
número de fracciones calculadas, acercará más el valor de π;
*/
using System;
					
public class Program
{
	public static void Main()
	{
		//declaramos las variables
        string entrada;
        int n;
        double lower;
        double operacion=0,contador=0, constante=-1;

        //indica lo que hace el programa
        Console.WriteLine("Este programa calcula el valor de π/4 con fracciones continuas");
        Console.WriteLine("Ingrese el número de fracciones a calcular:");
        entrada = Console.ReadLine(); //almacena la cadena de caracteres
        int.TryParse(entrada, out n); //utilizamos el metodo tryparse para comparar las entradas

        //ciclo while para ingresar correctamente n 
        while(int.TryParse(entrada, out n) == false || (n<1) ){
            Console.WriteLine("Introduzca un número entero positivo!");//mensajhe de advertencia
            Console.Beep();//emite un pitido
            entrada = Console.ReadLine(); // almnacena la cadena de caracteres
            int.TryParse(entrada, out n); //utilizamos de nuevo el metodo tryparse
        }

        //obtiene la  constante y contador en cociente para ir de alli hacia atras
        for(int i=1; i<=n; i++)
        {
            constante+=2;
            contador+=constante;
        }

        //coloco las condiciones iniciales
        lower=constante+(contador/(contador+constante+2));
        
        //ciclo for pricipal que va hacia atras
        for(int j=n-1; j>=1; j--)
        {
            contador-=constante;
            constante-=2;           //Voy regresando y asisgando a lower
            lower=constante+(contador/lower);
        }
        //resultado de la aproximacion
        operacion=1/(lower); //Lower total 

        //imrpime en pantalla la aproximacion
        Console.WriteLine("La aproximación es {0}",operacion); //muestar la aproximacion
        Console.Beep();//emite un pitido
    }
}