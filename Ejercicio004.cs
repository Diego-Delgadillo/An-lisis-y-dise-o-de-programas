// Ejercicio 004
/*
Generar un programa que permita generar un triángulo con *, solicitando al usuario el número
de filas a generar (en un intervalo de 1 a 20).
*/

public class Program{
    public static void Main(){
        //declaro variable para filas
        int filas = 0;

        Console.WriteLine("Este programa genera un triángulo de la forma '*'");

        
        Console.WriteLine("Ingrese el número de filas a generar: ");
        //almacena el valor de las filas
        filas = Convert.ToInt32(Console.ReadLine());

        while(filas < 1 || filas >20){

            if(filas < 1 || filas >20)
            {
                Console.WriteLine("Ingrese un número entre 1 y 20!");
                Console.Beep();// emite pitido
                Console.WriteLine("Ingrese el número de filas a generar: ");
                //almacena el valor de las filas
                filas = Convert.ToInt32(Console.ReadLine());
            }
 
        }
        //Cuando el numero esté dentro del intervalo
        //Creamos un ciclo for anidado de mod que unos crea las filas y otro las columnas
        for(int i=1; i<=filas; i++){
            for(int j=1; j<= i; j++){
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}