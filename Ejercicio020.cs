/*
Ejercicio 020
Generar el programa que permita mostrar el desarrollo del binomio de Newton
*/

using System;
using System.Threading.Tasks.Dataflow;

public class Program
{
	public static void Main()
	{
		//declaramos las variables a utilizar
        string entrada;
        int n;

        //muestra lo que hace el programa
        Console.WriteLine("Este programa desarrolla el binomio de Newton");
        Console.WriteLine("Introduzca el exponente deseado (debe ser menor a 15) ");
        entrada = Console.ReadLine(); //almacena la entrada como cadena de caracteres
        int.TryParse(entrada, out n); //utilizamos el metodo try parse

        //ciclo de control para ingresar correctamente los numeros
        while(int.TryParse(entrada, out n) == false || n<1){
            Console.WriteLine("Introduzca un numero positivo menor a 15"); // mensaje de error 
            entrada = Console.ReadLine(); //vuelve a pedir el numero
            int.TryParse(entrada, out n); // ocupamos de nuevo el metodo tryparse
        }

        //ciclo para calcular el binomio de newton
        for(int r=0;r<=n;r++)
        {
            //calculamos el coeficeinte binomial
            long fac = 1, fac2 = 1, fac3= 1; //declaramos las variables como tipo long
            for(int i=1; i<=n; fac*=i, i++); //factorial n!
            int o = n - r;  
            for(int j=1; j<=o; fac2*=j, j++); //factorial (n - r)!
            for(int k=1; k<=r; fac3*=k, k++); //factorial r!
            //Operacion n!/((n-r)! * r)
            double coefBim = fac/(fac2*fac3);
            
            //condicional para poder imprimir el binomio
            if(r==0)
            Console.Write("(a+b)^{0}= ",n); // imprime la forma del binomio
            
            if((n-r) != 0) //si es diferente de cero
            {
                if((n-r)==1)
                    Console.Write("{0}·a",coefBim); //Para a^1
                else
                    Console.Write("{0}·a^{1}",coefBim,(n-r));
                if(r != 0)
                {
                    if(r == 1)
                        Console.Write("·b"); //Para b^1
                    else
                        Console.Write("·b^{0}",r);
                }   
            }
            else
            {
                Console.Write("{0}·b^{1}",coefBim,r);
                continue;   //es para que no se imprima un "+"
            }
            Console.Write(" + ");  //imprime el "+" para dar paso al siguiente termino
        }
        Console.Beep();
	}
}