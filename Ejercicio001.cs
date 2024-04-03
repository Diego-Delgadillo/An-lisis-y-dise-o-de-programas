using System;

// Ejercicio 1- Calcular el factorial de un número entero positivo 


public class Program{
    public static void Main(){  

        //Declaramos las variables a utilizar
        int n = -1;
        int factorial = 1;
        Console.WriteLine("Este programa calcula el factorial de un número entero par");

        //Este bucle nos ayuda a solo acepatar numero enteros positivos
        while(n < 0){
            Console.WriteLine("Ingrese un número: ");
            // Convierte de cadea de texto a entero de 32 bits
            n = Convert.ToInt32(Console.ReadLine());
                if(n < 0){
                    Console.WriteLine("Ingrese un número entero mayor de 0! \a");
                }
        }
        
            //Creamos un ciclo for que nos ayuda a calcular el factorial
            for (int i = 1; i<=n ; i++){
                //multiplica el valor anterior emepezando desde 1 por el iterador (i)
                factorial *=  i;
            }

            //Imprime en consola el valor del factorial
            Console.WriteLine("El factorial de {0} es: {1}",n, factorial);
    }
}