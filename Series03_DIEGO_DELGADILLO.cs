// DIEGO RICARDO DELGADILLO GÓMEZ - 1MM4
// SERIRE NO.3

using System;

public class Program{
    public static void Main(){
        // creamos una funcion para calcular el factorial
        static long factorial(int N){
            // declaramos las variables a utilizar
            long result; // variable del resultado
            int i; // iterador del ciclo for

            // creamos el ciclo que calcula el factorial
            for(i = 1, result = 1; i <= N; result *= i, i++);
            // regresa el valor la funcion con el factorial de n
            return result;
        }

        // declaramos las variables a utilizar
        int n = -1;
        double resultado = 0;
        long denominador = 0;

        //muestra la funcion del programa
        Console.WriteLine("Este programa calcula la serie no.3: 8/(n*(2*n+1)!)");


        while(n <=0 ){
            Console.WriteLine("Ingrese el número de elementos a calcular: ");
            //almacena el valor de datos a calcular en la variable n
            n = Convert.ToInt32(Console.ReadLine());

            if(n <=0 ){
                Console.WriteLine("Ingrese un número entero mayor de 0!");
                Console.Beep();
                Console.WriteLine("");
            }


            else{
                // creamos un ciclo for para la parte del denominador
                for(int i = 1; i <= n; i++){
                    int argumentoFactorial;
                    argumentoFactorial = i+2;
                    denominador = ((i)*(factorial(argumentoFactorial)));
                    // va guardando el valor de cada valor obtenido y lo asigna a la variable "resultado"
                    resultado += (8.0/denominador);
                }
                
                Console.WriteLine("");
                Console.WriteLine("El resultado es: {0:N2}", resultado);
                Console.Beep();
                Console.ReadKey(true);
            }
        }

    }
}