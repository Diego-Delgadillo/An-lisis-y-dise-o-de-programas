/*
Ejercicio 019
Programa para la generación de figuras con asteriscos *
*/

using System;
					
public class Program
{
	public static void Main()
	{
		//declaramos las variables a utilizar
        string figura;
        string entrada;
        int n , m;

        //Imprime las funciones del programa
        Console.WriteLine("Este programa gener una serie de figuras");
        Console.WriteLine("Seleccione el numero de figura");
        Console.WriteLine("•1 Pirámide");
        Console.WriteLine("•2 Medio diamante");
        Console.WriteLine("•3 Diamante");
        Console.Write("\n\n");
        Console.Write("Seleccion: ");
        figura = Console.ReadLine(); //almacena la cadena de caracteres
        int.TryParse(figura, out m); //utilizamos la funcion tryparse para verfiifcar que sea un entero

        //ciclo de control para que sea iungresado un numero válido
        while(int.TryParse(figura, out m) == false || m<1 || m>3){
            Console.WriteLine("Introduzca un numero válido!"); //pide ingresar ded nuevo un numero
            Console.Beep();
            figura = Console.ReadLine(); // vuelve a capturar la cadena
            int.TryParse(figura, out m); //vuelve a utilizar el metodo tryparse
        }

        //pide el numero de filas al usuario
        Console.WriteLine("Introduzca el numero de filas (Máximo 20):");
        entrada = Console.ReadLine(); //almacena la cadena
        int.TryParse(entrada, out n); //utilizamos de nuevo el metodo tryparse

        //usamos de nuevo un ciclo de control para manejar adecuadamente los numeros
        while(int.TryParse(entrada, out n) == false || n<1 || n>20){
            Console.WriteLine("Introduzca un numero positivo menor a 20!"); //pide ingresar ded nuevo un numero
            Console.Beep();
            entrada = Console.ReadLine();  // vuelve a capturar la cadena
            int.TryParse(entrada, out n);  //vuelve a utilizar el metodo tryparse
        }

        //ciclos para generar cada figurac

        //Figura de la pirámide
        if(m==1) 
        {
            for(int i=1; i<=n; i++) //Saltador de filas
            {
                for(int j=1; j<=i; j++) //ciclo que genera los asteriscos
                {
                    Console.Write("*");// imprime cada asterisco
                }
                Console.Write("\n"); //da un salto de lina
            }
        }
        else if(m==2) //ciclo para la figura del medio diamante
        {
            for(int i=1; i<=n; i++) //Saltador de filas parte arriba
            {
                for(int j=1; j<=i; j++) //coloca asteriscos
                {
                    Console.Write("*"); //imprime asteriscos
                }
                Console.Write("\n");
            }
            for(int k=1; k<=n+1; k++) //coloca una linea en medio
                {
                    Console.Write("*"); //imprime asteriscos
                }
            Console.Write("\n");
            for(int i=n; i>=1; i--) //Saltador de filas parte abajo
            {
                for(int l=1; l<=i; l++) //coloca asteriscos
                {
                    Console.Write("*");  //imprime asteriscos
                }
                Console.Write("\n"); //da un salto de linea 
            }
        }
        else if(m==3) //ciclo para la figura
        {
            int blancos = n; //Establece la cantidad de espacios blanos de la fila 1
            for(int i=1; i<=n+1; i++) //Saltador de filas parte arriba Genera n+1
            {
                int puntos = (n+i) - blancos; //Establece la cantidad de asteriscos de la fila 1
                for(int j=1; j<=blancos; j++) //Poneblancos especial
                {
                    Console.Write(" "); 
                }
                for(int k=1; k<=puntos; k++) //Ponepuntos especial
                {
                    Console.Write("*"); 
                }
                Console.Write("\n");
                blancos--; //Describe la reduccion de blancos fila por fila
            }
            blancos=1; //Vuelvo a asignar a blancos a 1
            for(int i=0; i<=n-1; i++) //Saltador de filas parte abajo (Modificado para que puntos sea congruente)
            {
                int puntos = (2*n-i-blancos); //Establece la cantidad de asteriscos de la fila n+2
                for(int j=1; j<=blancos; j++) //Poneblancos especial
                {
                    Console.Write(" "); 
                }
                for(int k=1; k<=puntos; k++) //Ponepuntos especial
                {
                    Console.Write("*"); 
                }
                Console.Write("\n");
                blancos++; //Describe el aumento de blancos fila por fila
            }
        }
	}
}