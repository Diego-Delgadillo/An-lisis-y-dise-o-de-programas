// DIEGO RICARDO DELGADILLO GÓMEZ - 1MM4
// SERIRE NO.4


using System;

public class Program{
    static public void Main(){

        //creamos una funcion para calcular el factorial
            static long factorial(int N){
            // declaramos las variables a utilizar
            long result; // variable del resultado
            int i; // iterador del ciclo for

            // creamos el ciclo que calcula el factorial
            for(i = 1, result = 1; i <= N; result *= i, i++);
            // regresa el valor la funcion con el factorial de n
            return result;
        }

        //colocamos las variables a utilizar
        int n = -1; // variable que almacena los elementos a calcular
        double result = 0; // variable para almacenar el resultado
        double numerador; // variable para almacenar el numerador
        double denominador; // variable para almacenar el denominador
    
        //muestra meensaje de loq ue hace el programa
        Console.WriteLine("Este programa calcula la serie no.4: ((-1)^n/(2*n)!)");

        //ciclo whiel para ingresar solo enteros positivos
        while(n <= 0){
            //solicita ingresar n cantidad de datos a calcular
            Console.WriteLine("Ingrese el número de elementos: ");
            n = Convert.ToInt32(Console.ReadLine());

            //en caso de ser menor que 0 manda el mensaje
            if(n <= 0){
                Console.WriteLine("Ingrese un número mayor de 0!");
                Console.Beep();
                Console.WriteLine("");
            }

            // en caso contrario si es mayor de 0 procede el codigo y se ejecuta lo siguiente
            else{
                //Creamos un ciclo for para calcular la serie(NOTA: EL CASO ESPECIAL DE n=0 SE AGREGA AL FINAL YA QUE ES IGUAL A 1)
                for(int i = 1; i <= n; i++){
                    numerador = (Math.Pow(-1,i));
                    // creamos una variable para el valor que tomara la funcion de factorial
                    int argumentoFactorial;
                    argumentoFactorial = (2*i);
                    //calculamos el denomindor llamando a la funcion factorial
                    denominador = factorial(argumentoFactorial);

                    //calculamos el resultado y lo vamos sumando mediante: 
                    result += (numerador/denominador);
                }

                //finalmente mostramos el resultado obtenido de la serie al usuario
                Console.WriteLine("");
                // se le agrega +1 por el caso especial del 0 
                Console.WriteLine("El resultado es: {0:N4}",result+1);
                Console.Beep(); // emite una alarma o pitido la computadoraw
                Console.ReadKey(true); // presiona una tecla para continuar
            }
        }
    }
}