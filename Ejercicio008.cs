using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ejercicio 008
/*
Generar un programa que permita imprimir los números de la serie de Fibonacci, permitiendo
que se ingrese el número de elementos a desplegar N, como valor entero y positivo. Recordar
que la serie de Fibonacci es: 0,1,1,2,3,5,8,13,21,34,...
*/

namespace Ejercicio008
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //declaramos las variables a utilizar
            int n = -1;
            int x = 0; // variable que toma el valor de z
            int y = 1; // variable que toma el valor de x
            int z = 1; // variable principal que compara a las otras 

            //muestra lo que hace el programa
            Console.WriteLine("Este programa calcula la serie de fibonacci"); 


            while (n <= -1)
            {
                Console.WriteLine("Ingrese el número de elementos a calcular: ");
                n = Convert.ToInt32(Console.ReadLine());  //alamcena y convierte a entero
                Console.WriteLine("");// deja un espacio

                if(n <= -1)
                {
                    Console.WriteLine("Ingrese un núnero entero positivo!");
                    Console.Beep();
                }

                else
                {
                    Console.Write("0"); // imprime el primer elemento que es 0
                    Console.Write("\t"); // sirve para dejar un espacio de tabulado 

                    //creamos un ciclo for para calcular la serie
                    for (int i = 1; i < n; i++)
                    {
                        z = x + y; // 1 2 3 5 8
                        Console.Write(z);// imprime el valor de la variable z
                        Console.Write("\t"); // sirve para dejar un espacio de tabulado 

                        x = y; // 1 1 2 3 8
                        y = z; //1 2 3 5 8
                    }
                    Console.Beep(); // da un pitido en la consola
                    Console.ReadKey(true); // espera una tecla para finalizar 
                }
            }
        }
    }
}
