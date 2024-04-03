

/*
Ejercicio 3- Generar un programa que, al ingresar 3 números positivos, se establezca que, si son
longitudes de líneas rectas, estás puedan formar un triángulo. Solamente se forma un
triángulo, cuando la suma de las 2 longitudes de las rectas es mayor que la otra (esto es, si las
longitudes son A, B y C, A+B>C, A+C >B y B+C>A)
*/

using System;

public class Program{
    public static void Main(){
        //Primero declaramos las variables de las longitudes
        int a = 0;
        int b = 0;
        int c = 0;

        //bucle para aceptar solo enteros positivos
        while(a < 1){
            Console.WriteLine("Ingrese la primer longitud: "); // pide el dato de a
            a = Convert.ToInt32(Console.ReadLine()); // convierte y almacena el dato
            }

        while(b < 1){
            Console.WriteLine("Ingrese la segunda longitud: "); //pide el dato de b
            b = Convert.ToInt32(Console.ReadLine()); // convierte y almacena b
        }

        while(c < 1){
            Console.WriteLine("Ingrese la tercer longitud: "); // pide el dato de c
            c = Convert.ToInt32(Console.ReadLine()); // convierte y almacena c
        }

        //Abrimos el condicional que detemrina si es un triángulo
        if(((a+b) > c) && ((a+c) > b) && ((b+c) > a)){
            Console.WriteLine("Las longitudes {0}, {1}, {2} sí forman un triángulo",a,b,c);
        }
        else{
            Console.WriteLine("Las longitudes {0}, {1}, {2} no forman un triángulo!",a,b,c);
        }


    }
}










