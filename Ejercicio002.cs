
/* Ejercicio 2- 2. Generar un programa que indique si, al ingresar un año como un número entero positivo, este
sea o no bisiesto. Un año es bisiesto si es múltiplo de 4, exceptuando los múltiplos de 100, que
sólo son bisiestos cuando son múltiplos además de 400, por ejemplo, el año 1900 no fue
bisiesto, pero el año 2000 si lo es

*/

using System;


public class Program{

    public static void Main(){

        // Declaramos la variable que almacena el año
        int year = 0;

        Console.WriteLine("Este programa indica si un año es bisiesto o no");

        //Ciclo para solo ingresar años enteros positivos
        while(year < 1){
            //Solicita el año
            Console.WriteLine("Ingrese el año: ");
            //Almacena y convierte a entero de 32 bits la entrada de datos
            year = Convert.ToInt32(Console.ReadLine());
            if(year <= -1){Console.WriteLine("Ingrese un año válido! \a");}

            else{
                 //Abrimos un condicional
                if(year % 4 == 0){
                    if(year % 400 == 0){
                        Console.WriteLine("El año {0} si es bisiesto!",year);
                    }
                    else{
                        Console.WriteLine("El año {0} no es bisiesto! \a",year);
                    }
                }
                else{
                    Console.WriteLine("El año {0} no es bisiesto! \a",year);
                }
            }

        }

       
        
    }

}

