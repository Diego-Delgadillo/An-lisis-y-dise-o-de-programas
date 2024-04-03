/*
Ejercicio 013
Generar un programa que permita obtener una cantidad N de números pseudoaleatorios
(donde N es un número entero, mayor a 0) utilizando para ello el método/algoritmo de
generación de números congruencial.
*/

using System;

public class Program
{
	public static void Main()
	{
        //muestra el mensaje de lo que hace el programa
		Console.WriteLine("Este programa genera una N cantidad de números pseudoaleatorios");

        //declaramos las variables a utilizar
        double N, R, r, h; //
        double[] Pr; //este arreglo nos permite alamcenar los parametros a, b y m
        Pr = new double[3]; //este tendra valor insgresado por el usuario colocamos new para que se mdoifique el arreglo 3 veces
		string c; //Variable de tipo char que almacena lo ingresado mediante la consola
		bool num;// variable para comprobar si es un numero positivo

        //ciclo de control para ingresar los valores correctamente
        do
 		{
   		Console.WriteLine("\nIngresa la cantidad de números a generar:"); //muestra mensaje para ingresar numero
   		c = Console.ReadLine(); //obtiene la cadena de caracteres
   		num= double.TryParse(c, out N); //usamos le metodo tryparse para que sean positivos
 		}
 		while (!num); //se ejecuta mientras esto sea falso (0)
		
		N = Convert.ToDouble(c); // adquiere el valor del numero que se ingreso correctamente 


        //ciclo para pedir los 3 parametros (a,b,m)
        for(int i=0 ; i<3 ; i++)
        {
            //ciclo para contolar que siolo ingresen positivos
            do
            {
            Console.WriteLine("\nIngresa el parametro {0}:", i+1); //pide que ingrese los parametros
            c = Console.ReadLine(); //obtiene el valor ingresado
            num= double.TryParse(c, out Pr[i]); // usa el metodo tryparse para ver si es un positivo
            }
            while (!num); //mientras la condicion sea falsa se ejecuta
            
            Pr[i] = Convert.ToDouble(c); //en cada iteracion se convierte a una variable de tipo double
        }
        R = N; //asignamos el valro de R a N(variable que nos ayuda  llevar un control en el ciclo for)


        //ciclo que calcula los numeros
        for(int i = 0 ; i<N ; i++)
        {
            Console.WriteLine("\n\n El proceso para el número pseudo-aleatorio {0} sera de la manera", i+1);
            
			h=R; // la variable h es el valor de R(Xn)

			//decimos que Xn=(aXn +b)mod m
            //multiplica a R por el parametro a Pr[0]
            //luego suma el parametro b Pr[1]
            //finalment obtiene el modulo de lo obtenido entre el parametro m Pr[2]
			R=((R * Pr[0]) + (Pr[1])) % Pr[2];

            //imprime los datos del proceso 
			Console.WriteLine("\nXn+1 = ({0} * {1} + {2}) mod {3} = {4}", Pr[0] , h, Pr[1], Pr[2], R);
            
            //el numero aleatorio esta dado por Un=Xn/m
            //r = Un, Xn=h, Pr[2]=m
			r=h/Pr[2];
            
            //indica los valores obtenidos
			Console.WriteLine("\nEl numero ps{0} se calcula como {1}/{2} \n Entonces U{0} = {3}",i+1 , h, Pr[2], r);
        }
        Console.Beep();//emite un pitido
	}
}