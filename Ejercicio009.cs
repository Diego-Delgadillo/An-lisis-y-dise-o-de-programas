using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

//Ejercicio 009
/*
Generar un programa que permita obtener y desplegar los N primeros números primos, en
donde N es un número entero positivo, el cual ingresa el usuario. Se debe recordar que los
números primos son aquellos que solo son divisibles
*/

namespace Ejercicio009
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //creamos una funcion para determinar si un numero es primo
           bool esPrimo(int numero)
            {
                //para los casos especiales cremos una condicion
                if(numero == 0 || numero == 1 || numero == 4)
                {
                    return false; //nos devuelve un valor falso o "0"
                }

                //de otro modo, determinamos si es primo con un ciclo for
                for (int x = 2; x < numero / 2; x++) {

                    //obtenemos el modulo y si no tiene residuo (es igual a 0) 
                    //entonces no es primo
                    if (numero % x == 0)
                        return false;
                }
                return true;// en caso contrario, decimos que si es un numero primo :D

            }

            //ahora creamos el programa proncipla y llamaremos a la funcion creada previamente

            //declaro la variable de n elementos
            int n = -1;


            Console.WriteLine("Este programa desplega los numeros primos a partir de un numero N");

            //creamos un ciclo while para ingresar solo enteros positivos
            while (n <= -1)
            {

                Console.WriteLine("Ingrese el número de elementos: ");
                n = Convert.ToInt32(Console.ReadLine());   //almacena y convierte la cadena a entero de 32 bits


                //indica que ingrese de nuevo el número
                if(n <= -1)
                {
                    Console.WriteLine("Ingrese un entero positivo!");
                    Console.Beep();
                }

                //cuando sea un numero entero mayor, entonces procede
                else
                {
                    //creamos un ciclo for que nos permita imprimir los numeros primos, llamando a la funcion

                    for (int i = 1; i <= n; i++)
                    {
                        //condicional llamando a la funcion es primo
                        if (esPrimo(i))
                        {
                            Console.Write(i);
                            Console.Write("\t");
                        }
                    }
                    Console.Beep();
                    Console.ReadKey(true);
                }
            }
        }
    }
}
