/*
Ejercicio 016
Generar un programa que permita obtener las soluciones de un polinomio de segundo grado
de la forma: p(x) = ax^2 + bx +c
*/

using System;
					
public class Program
{
	public static void Main()
	{
		//declaramos las variables a utilizar
        string entrada; //varaible de tipo string para la entrada del metod tryparse
        double a,b,c,x1,x2,r,i,i1; // variables de coeficientes y valores de las soluciones

        //Menu
        Console.WriteLine("Este programa calcula las soluciones de un polinomio de segundo grado");
        Console.WriteLine("Ingrese los coeficientes para el polinomio de la forma: ax^2+bx+c");

        //obtenemos el coeficiente a
        Console.WriteLine("Introduzca a:"); //muestra el mensaje 
        entrada = Console.ReadLine(); // obtiene la cadena de caracteres
        double.TryParse(entrada, out a); // usamos el metodo tryparse para verificar que se cumpla la condicion
        //ciclo while para ingresar correctamente los numeros
        while(double.TryParse(entrada, out a) == false){    
            Console.WriteLine("Introduzca un a real o flotante");//mensaje de error
            Console.Beep();
            entrada = Console.ReadLine(); //vuelve a obtener la cadena de caracteres
            double.TryParse(entrada, out a); //usamos el metodo tryparse
        }

        //obtenemos el coeficiente b
        Console.WriteLine("Introduzca b"); //muestra el mensaje 
        entrada = Console.ReadLine();  // obtiene la cadena de caracteres
        double.TryParse(entrada, out b); // usamos el metodo tryparse para verificar que se cumpla la condicion
        //mientras no se cumpla la condicion establecida
        while(double.TryParse(entrada, out b) == false){
            Console.WriteLine("Introduzca un b real o flotante");
            entrada = Console.ReadLine();//vuelve a obtener la cadena de caracteres
            double.TryParse(entrada, out b);//usamos el metodo tryparse
        }


        //obtenemos el coeficiente c
        Console.WriteLine("Introduzca c");//muestra el mensaje 
        entrada = Console.ReadLine(); // obtiene la cadena de caracteres
        double.TryParse(entrada, out c);// usamos el metodo tryparse para verificar que se cumpla la condicion
         //mientras no se cumpla la condicion establecida
        while(double.TryParse(entrada, out c) == false){
            Console.WriteLine("Introduzca un c  real o flotante");
            entrada = Console.ReadLine(); //vuelve a obtener la cadena de caracteres
            double.TryParse(entrada, out c);//usamos el metodo tryparse
        }

       
        //evalaumos el discriminante de la formula general
        if(((Math.Pow(b,2))-(4*a*c))>=0)
        {
            x1=((-1*b)+Math.Sqrt((Math.Pow(b,2))-(4*a*c)))/(2*a); //solucion 1 
            x2=((-1*b)-Math.Sqrt((Math.Pow(b,2))-(4*a*c)))/(2*a);//solucion 2

            Console.WriteLine("La solucion es:");
            Console.WriteLine("x1 = {0}",x1);
            Console.WriteLine("x2 = {0}",x2);
            Console.WriteLine("Ecuación: ");
            Console.WriteLine("x = -({1})±√(({1})²-4·{0}·{2}) / 2·{0}",a,b,c);
        }
        else //en este caso la soluciones esta dada por un numero complejo
        {
            Console.WriteLine("");
            Console.WriteLine("Las soluciones están dadas por un número complejo\n");

            r=(-1*b)/2*a; //parte real
            i=(Math.Abs((Math.Pow(b,2))-(4*a*c))); //mostrar en raiz y divison
            i1=(Math.Sqrt(Math.Abs((Math.Pow(b,2))-(4*a*c))))/(2*a); //parte imaginaria
            Console.WriteLine("x1 = {0} + √{1}/{2}i de forma que x1 = {0} + {3:F4}i ",r,i,2*a,i1);
            Console.WriteLine("x2 = {0} - √{1}/{2}i de forma que x2 = {0} - {3:F4}i ",r,i,2*a,i1);
            Console.WriteLine("");
            Console.WriteLine("Ecuación: ");
            Console.WriteLine("x = -({1})±√(({1})² - 4·{0}·{2}) / 2·{0}",a,b,c);
            Console.Beep();
        }
    }
}