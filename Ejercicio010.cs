/*
Ejercicio 10 
Generar un programa que permita Imprimir los N números de la Serie de Padovan , donde N
es un número entero positivo que el usuario debe ingresar para obtener los valores de la serie

*/

using System;
					
public class Program
{
	public static void Main()
	{   
		uint n;
 		string c ;
 		bool num;
 
 		do
 		{
   		Console.WriteLine("Este programa calcula n números de la serie de Padovan :D \n Ingresa el número de digitos de la serie a imprimir:");
   		c = Console.ReadLine();
   		num= uint.TryParse(c, out n);
 		}
 		while (!num);
	
		
		n =Convert.ToUInt32(c);

        int[] pad = new int[n];
        
		Console.WriteLine("\nLos {0} números de la serie de padovan son: ", n);
		
		for(int i=0 ; i<n ; i++)
        {
            if((i-2)<=0 || (i-3)<0) 
            {
            pad[i]=1;
            }
            else{
            pad[i]=pad[i-2]+pad[i-3];
            }
        }

        foreach(long tmp in pad)
            Console.WriteLine(tmp);

	}
}