// DIEGO RICARDO DELGADILLO GOMEZ -1MM4 
// CODIGO SERIE NO.1 (SUMA DE FACTORIALES)

using System;
					
public class Program
{
    public static void Main(){
    // declaramos las variables a utilizar
    // n = numero ingresado, j e i = son los iteradores, 
    //resultFact = almacena el resultado de cada factorial y result = almacena el resultado final
    int n = -1;
    int i;
    double result = 0;
    double resultFact = 1;



    //indica lo que hace el programa
    Console.WriteLine("Este programa calcula la sumatoria no.1:  (1/n!)");


    while(n <= 0){
        // pide los datos a calcular
        Console.WriteLine("Ingrese el número de datos a calcular:");
        //convierte a entero de 32 bits y almacena el valor
        n = Convert.ToInt32(Console.ReadLine());

            if(n <= 0){
                Console.WriteLine("Ingrese un número entero mayor de 0!");
                Console.Beep();
                Console.WriteLine("");
            }

            else{
                //creamos dos ciclos for anidados el primero se repite n veces y el segundo calcula el factorial y lo suma a una variable
                for(i = 1; i < n; i++){

                    //Obtenemos el factoiral del numero del iterador (empezando desde 1)
                    resultFact *= i;
                    //suma cada factorial y lo almacena en una variable
                    result += (1/resultFact);
                }
                
                //Muestra el resultado obtenido
                Console.WriteLine("");
                //Se le suma el +1 puesto que inicia en 0 la sumatoria y 0! = 1
                //el N:2 es para mostrar solamente 2 decimales del resultado en la consola
                Console.WriteLine("El resultado es: {0:N4}",result+1);
                //emite un pitido de alerta
                Console.Beep();
            }

    }
    
    }
}