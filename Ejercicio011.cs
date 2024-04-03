/*
Ejercicio 11
Generar un programa que permita el ingreso de un número entero positivo en un intervalo de
0 a 1,000,000, y representarlo como la suma de sus unidades, decenas, centenas..., esto es, si
se ingresa el valor de 1942 se imprimirá en pantalla: 1942 = 1000 + 900 + 40 + 2;
*/

using System;
					
public class Program
{
	public static void Main()
	{
        //Muestra lo que hace el programa
		Console.WriteLine("Este programa separa un número en el intervalo de 0 y 1,000,000 en sus respectivas unidades");
		
        //declaramos las variables a utilizar
        uint n;
 		string c;
 		bool num;
 
 		do
 		{
   		Console.WriteLine("Ingresa el número a convertir:"); //pide ingresar el numero
   		c = Console.ReadLine(); //obtiene la entrada
   		num= uint.TryParse(c, out n); //solo acepta enteros de 32 bits
 		}
 		while (!num); 
	
		
		n =Convert.ToUInt32(c); //coniverte a entero de 32 bits

        //declaramos las variables para: mi = millar, ce = centenas, de = decenas, un = unidades
        int mi=0, ce=0, de=0, un=0;

        //creamos un ciclo para las unidades de millar
        while(n>=1000)
        {
            n-=1000;//resta al valor de n
            mi++;//aumenta el valor de millar
        }

        while(n>=100)
        {
            n-=100;//resta al valor de n
            ce++;//aumenta el valor de centenas
        }

        while(n>=10)
        {
            n-=10;//resta al valor de n
            de++;//aumenta el valor de decenas
        }

        while(n>=1)
        {
            n-=1;//resta al valor de n
            un++;//aumenta el valor de unidades
        }

        //imprime los valores obtenidos
        Console.WriteLine("{0} = {1} + {2} + {3} + {4}", c, (mi*1000), (ce*100), (de*10), un);
	}
}