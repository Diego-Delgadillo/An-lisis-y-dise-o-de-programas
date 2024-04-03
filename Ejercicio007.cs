// EJERCICIO 7
/*
    Generar un programa que obtenga el Máximo Común Divisor (MCD) y el mínimo común
    múltiplo (mcm) de un par de números enteros positivos; existe un algoritmo ya establecido
    para este caso, se le conoce como algoritmo de Euclídes;
*/


using System;

public class Program()
{
    static public void Main()
    {
        // declaramos las variables a utilizar
        int a = 0; //variable que mantiene el valor inicial del numero1
        int b = 0; //variabel que mantiene el valor incial del numero2
        int numero1 = -2; //variable que almacena el primer numero
        int numero2 = -2; //variabl que almacena el segundo numero
        int residuo = -2; // variable que almacena el residuo de las divisiones sucesivas
        int mcd = 0; // variable para el maximo comun divisor
        int mcm = 0; //variable para el minimo comun multiplo

        //muestra lo que hace el programa
        Console.WriteLine("Este programa calcula el máximo común múltiplo de 2 números");

        //cremaos un ciclo para que solo ingrese enteros positivos
        while (numero1 <= -1)
        {
            Console.WriteLine("Ingrese el primer número: ");
            numero1 = Convert.ToInt32(Console.ReadLine()); // convierte y almacena el valor del numero1
            a = numero1;

            //si sigue siendo negativo, entonces
            if (numero1 <= -1)
            {
                Console.WriteLine("Ingrese un número entero positivo!");
            }   Console.Beep();
        }

        while (numero2 <= -1) { 

            Console.WriteLine("Ingrese el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine()); //convierte y almacene le valor del numero 2
            b = numero2;

            //si sigue siendo negativo, entonces
            if(numero2 <= -1) {
            Console.WriteLine("Ingrese un número entero positivo!");
            Console.Beep();
             }
        }


        while (residuo != 0){
            // hallamos el residuo de la divison mediante el modulo de numero y numero2
            //creamos un try catch
            try
            {
                residuo = (numero1 % numero2);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message); //meustra el error
                Console.WriteLine("No se puede dividir entre cero! ");
                Console.WriteLine("¡Reinicie el programa por favor!");
                break;
            }

            //mientras el residuo sea diferente de cero
            if (residuo != 0)
            {
                //de acuerdo con el teorema de euclides, los divisores pasan a ser dividendos
                //y los residuos pasan a ser los nuevos divisores
                numero1 = numero2; // pasa de ser divisor a ser dividendo
                numero2 = residuo; // el residuo ahora es un divisor 
            }
            else 
            {
                //si el residuo es == 0 entonces hallamos el mcd
                //por lo tanto numero2 era el ultimo divisor
                //asigno numero2 a mcd
                mcd = numero2;
            }
        }

        // ahora para el mcm, tenemos que: mcm(a,b)*mcd(a,b)= a*b
        //por lo tanto
        mcm = ((a*b) / (mcd));

        Console.WriteLine("");
        //Mostramos al usuario lo obtenido en este programa
        Console.WriteLine("El máximo común divisor de {0} y {1} es: {2}",a,b,mcd);
        Console.WriteLine("");
        Console.WriteLine("El minimo común múltiplo {0} y {1} es: {2}",a,b,mcm);
        Console.Beep();
        Console.ReadKey(true);
    }
       
 }
