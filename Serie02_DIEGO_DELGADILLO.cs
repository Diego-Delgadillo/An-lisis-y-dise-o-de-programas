// DIEGO RICARDO DELGADILLO GÓMEZ - 1MM4
// SERIRE NO.2

using System;

public class Program{
    public static void Main(){
        //declaramos las variables a utilizar
        int n= -1; // se deja con esta valor para el ciclo while que deja ingresar numeros positivos
        int i; // variable del iterador del ciclo for
        int j; // varible del segundo iterador para fcatorial del denominador
        double result = 0; // variable del resultado final
        double numerador = 0; // variable de la parte del numerador de la serie;
        double denominador; // variable que almacena el valor del denominador 
        double denominadorTotal = 0; // variable que almacena la sumna de los denominadores de la serie 
        double factorial = 1; // variable que almacena el factorial

        Console.WriteLine("Este programa calcula la sumatoria no.2:  ((2*n)*(n!^2)/(2n+1)!1)");

        //Creamos un ciclo while para solo ingresar positivos
        while(n <= 0){
            Console.WriteLine("Ingrese el número de elementos a calcular: ");
            n = Convert.ToInt32(Console.ReadLine());

            if(n <= 0){
                Console.WriteLine("Ingrese un número entero mayor de 0!");
                Console.Beep();
                Console.WriteLine("");
            }

            else{
                //iniciamos el ciclo for para calcular la serie
                for(i=1 ; i<= n; i++){
                    //calculamos el factorial
                    factorial *= i;
                    //calculamos el numerador
                    numerador = ((Math.Pow(2,i))*(Math.Pow(factorial,2)));
             
                    // calculamos el denominador
                    denominador = ((2*i)+1);
                    denominadorTotal = denominador;
                    //al resultado se le saca el factorial
                    // creamos otro ciclo for para el factorial del denominador
                    for(j = 1; j < denominador; j++){
                        denominadorTotal *= j;
                    }
                    
                    // calculamos el resultado
                    result += (numerador/denominadorTotal);
                }

                Console.WriteLine("");
                // mostramos el reultado final
                // le sumamos 1 ya que la serie empieza desde "0" y el ciclo for desde 1
                Console.WriteLine("El resultado es: {0}/{1}  ó  {2:N4}",numerador,denominadorTotal,result+1);
                Console.Beep(); // emite un pitido la computadora
                Console.ReadKey(true);  // espera una entrada para terminar
            }
        }
    }
}