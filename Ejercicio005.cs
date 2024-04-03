// Ejercicio 005
/*
Generar un programa que permita ingresar un par de números que representan la parte real
e imaginaria de un número complejo y mostrar sus posibles representaciones (binomial y
polar);
*/

using System;

public class Program{
    public static void Main(){
    //declaramos las variables a utilizar
    double real = 0;
    double imaginario = 0;
    double polar = 0;
    double cuadrados = 0;
    double angulo = 0;
    double arg = 0;

    //Muestra lo que hace el programa
    Console.WriteLine("Este programa muestra las representaciones binomial y polar de un número complejo");
    Console.WriteLine("Ingrese la parte real: ");
    // convierte y almacena el valro de la variable
    real = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese la parte imaginaria: ");
    // convierte y almacena el valro de la variable
    imaginario = Convert.ToInt32(Console.ReadLine());

    //Obtiene el modulo del numero complejo
    cuadrados = (Math.Pow(real,2)) + (Math.Pow(imaginario,2));
    polar = Math.Sqrt(cuadrados);

    //obtenemos el argumento del numero complejo
    
    arg = Math.Atan(imaginario/real);
    // ya que el resultado es en radianes convertimos a grados 
    angulo = ((arg*180)/Math.PI);

    //Muestra en consola
    Console.WriteLine("El complejo en forma binomial es: {0} + {1}i",real,imaginario);
    Console.WriteLine("El complejo en forma polar es : {0:N2}, {1:N2}°",polar,angulo);

    }
}




