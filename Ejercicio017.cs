/*
Ejercicio 8
Generar un programa que permita calcular el dígito de control del código de barras EAN-8
*/

using System;
					
public class Program
{
	public static void Main()
	{
		//declaramos las variables a utilizar
        string entrada, codigo;
        int n, digimpar=0, digpar=0,cant,control;    

        //muestra lo que hace el programa
        Console.WriteLine("Este programa calcula el digito de control EAN-8");
        Console.WriteLine("Ingrese el codigo universal de producto (8 dígitos): "); //pide ingresar el codigo del produco
        entrada = Console.ReadLine(); // obtiene la entrada
        int.TryParse(entrada, out n); // utilizamos el metodo tryparse para ingrear correctamente el numero

        //ciclo de control para asegurarse que sea un numero correcto
        while(int.TryParse(entrada, out n) == false || (entrada.Length != 8) ){
            Console.WriteLine("Introduzca un numero de 8 digitos!"); //mensaje de error
            Console.Beep();//emite un pitido
            entrada = Console.ReadLine(); //obtiene de nuevo la entrada
            int.TryParse(entrada, out n); //volvemos a utuliar le tryparse
        }
        codigo = entrada;
        
        //ciclo para calcular los digitos
        for(int i=0; i<7; i+=2) //Suma de digitos lugar impar 
        {
            string tmp = Convert.ToString(codigo[i]);
            digimpar += Convert.ToInt32(tmp);
        }   
        Console.WriteLine(digimpar); //imprime el digito impar

        for(int j=1; j<8; j+=2) //Suma de digitos lugar par
        {
            string tmp = Convert.ToString(codigo[j]);
            digpar += Convert.ToInt32(tmp);
        } 
        digpar*=3; //Multiplicamos por 3
        cant= digimpar + digpar;
        //Calculamos digito de control
        control= 10 - (cant%10);
        //Mostramos digito de control
        Console.WriteLine("Calculando digito de control...\n");
        Console.WriteLine("El digito de control es {0}",control);
        Console.WriteLine("Por tanto el codigo es: {0} {1}",codigo,control);
        Console.Beep();
    }
}