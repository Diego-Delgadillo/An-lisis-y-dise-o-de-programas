/*
Ejercicio 014
Programa para generar un triángulo de Pascal , en
donde el usuario ingrese el número de filas que desea observar del triángulo;

*/
using System;
					
public class Program
{
	public static void Main()
	{
        //imprime mensaje de lo que hace el programa 
		Console.WriteLine("Este programa imprime el triángulo de pascal dado el número de filas");
		
        //declaramos las variables a utilizar 
		uint n; // variable a comparar para aceptar enteros positivos
		string c; //variale de tipo string que almacena la cadena dde caracteres obtenidos 
		bool num; // variable de tipo bool para detectar si se cumpole le metodo tryparse
		
        //ciclo para ingresar datos correctamente
		do
 		{
   		Console.WriteLine("\nIngresa el número de filas a imprimir:"); //muestra el mensaje de ingresar el no. de filas
   		c = Console.ReadLine(); //obtiene la cadena de caracteras y la almacena en c
   		num= uint.TryParse(c, out n); //compara ccon le metodo tryparse
 		}
 		while (!num); //se ejecuta mientras la variabler num sea falso
		
		n = Convert.ToUInt32(c); // cdonvierte la cadena de caracteres obtenida en un entero de 32 bits sin signo
		int[,] triangulo = new int[n,n]; // declaramos un arreglo (triangulo) donde se van ingresando los valores (n)
		
        //creamos un ciclo for donde los extremos del triangulo llevan el numero 1
		for(int i=0 ; i<n ; i++)
		{
			triangulo[i,i]=1;
			triangulo[i,0]=1;
		}
		
        //ciclo para rellenar todo lo que va dentro del triangulo
		for(int i=2 ;  i<n ; i++)
		{
			for(int j=1 ; j<=i ; j++)
			{
				triangulo[i,j] = triangulo[i-1,j] + triangulo[i-1,j-1]; //rellena los espacios restandole 1 al iterador i y j 
			}
		}
		
		Console.WriteLine("\nEl triángulo de {0} filas\n", n);
		
        //ciclo para imprimir el triangulo
		for(int i=0 ;  i<n ; i++)
		{
			string fila=""; //sirve para dejar un espacip
			for(int j=0 ; j<=i ; j++)
			{
			 	fila += triangulo[i,j] + "\t"; //imprime los valores del triangulo
			}
			Console.WriteLine(fila);
		}
        Console.Beep();
		
	}
}