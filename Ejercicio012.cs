/*
Ejercicio 012
Programa que calcule el doble factorial (n!!) de un número entero positivo
*/

using System;
					
public class Program
{
	public static void Main()
	{
        //muestra el mensaje de lo que hace el programa
		Console.WriteLine("Este programa calcula el doble factorial de un número");
		
        //declaramos las variables a utilizar
		uint n; // para almancenar el valor del numero 
		string c; //declarmaos arbile tipo string para almacenar la cadena
		bool num;//variable tipoo num que revisa si es del tipo indicado con el método tryparse
        		

        //ciclo de control do while para ingresar solo enteros positivos
		do
 		{
   		Console.WriteLine("\nIngresa el número a calcular su doble factorial: ");// mesutra mensaje de ingresar numero

   		c = Console.ReadLine(); //obtiene la cadena de caracteres
   		num= uint.TryParse(c, out n);
 		}
 		while (!num); // mientras se cumpla la condicion de ser entero positivo
		
		int h = Convert.ToInt32(c); // declaramos la variabler que toma el valor del numero ingresado

        // ciclo for que calcula el doble factorial
        //iguala el valor del iterador i con el valor de la variable h
		for(int i=h, j=2 ; (i-j)>1 ; h*=(i-j), j+=2);
		
        Console.Write("El resultado es: ");
		Console.WriteLine(h);//muestra el resultado
		Console.Beep();
	}
}