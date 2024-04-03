/*
Ejercicio 018
Generar un programa que permita la lectura de N datos ingresados por el usuario en un
intervalo y aplicar el método de mínimos cuadrados para calcular la recta que pase por dichos puntos
*/

using System;
					
public class Program
{
	public static void Main()
	{
		//declaramos las variables a utilizar
        string entrada;
        int n;
        double m , b, xy=0, x=0, y=0, x2=0, absx2=0;

        //Muestra lo que hace el programa
        Console.WriteLine("Este programa calcula los mínimos cuadrados de una serie de datos"); 
        Console.WriteLine("Ingrese el numero de datos:"); 
        entrada = Console.ReadLine(); //ingresa la cadena de caracteres
        int.TryParse(entrada, out n); //utilizamos el metodo tryparse para comparar que sea correcto

        //ciclo de control para ingresar correctamente los datos
        while(int.TryParse(entrada, out n) == false || n<1 ){
            Console.WriteLine("Introduzca un numero correcto");//vuelve a pedir que se ingrese el numero
            entrada = Console.ReadLine(); //almacena de nuevo en entrada
            int.TryParse(entrada, out n); //volvemos a utilizar tryparse
        }

        //Creamos un arreglo para almacenar las coordenadas ingresadas por el usuario
        double[,] Cords = new double[n,2];

        //Este ciclo for es para almacenar las coordenadas ingresadas por el usuario
        for(int i=0; i<n; i++)  
        {
                Console.WriteLine("Ingrese coordenada {0}",i+1); //mensaje de ingresar 
                Console.Write("En X: "); 
                Cords[i,0] = Convert.ToDouble(Console.ReadLine());//convierte y almacena en el array

                Console.Write("En Y: ");
                Cords[i,1] = Convert.ToDouble(Console.ReadLine());//convierte y almacena en el array
        }

        //calcula la pendiente (m)
       
        for(int j=0; j<n ; xy += (Cords[j,0])*(Cords[j,1]), j++); //Sumatoria de x*y
        for(int k=0; k<n ; x += Cords[k,0], k++); //Sumatoria x
        for(int l=0; l<n ; y += Cords[l,1], l++); //Sumatoria y
        for(int o=0; o<n ; x2 += Math.Pow(Cords[o,0],2), o++); //Sumatoria x2
        absx2 = Math.Pow(Math.Abs(x),2);

        //Procedemos a sacar m

        m= ((n*xy)-(x*y))/((n*x2)-absx2);

        //Sacamps b
        
        b=((y*x2)-(x*xy))/((n*x2)-absx2);

        //imprime al usuario el resultado
        Console.WriteLine("\n");
        Console.WriteLine("La recta generada es y = ({0:F4})x + {1:F4}",m,b);
        Console.Beep();
	}
}