// DIEGO RICARDO DELGADILLO GÓMEZ - 1MM4
// SERIRE NO.5

using System;

public class Program{
    public static void Main(){
        
    //declaramos las variables a utilizar
    int n = -1; // variabel de elementos a calcular
    double resultado = 0; //variable que almacena el resultado
    double producto1; // variable para el primer producto (2*n/(2*n-1))
    double producto2; // variable para el primer producto (2*n/(2*n+1))

    //Muestra lo que hace el programa
    Console.WriteLine("Este programa calcula la serie no.5: ((2*n)/(2*n-1)*(2*n)/(2*n+1))");

        //Creamos un ciclo while para que solo se ingresen enteros positivos
        while(n <= 0){

            Console.WriteLine("Ingrese el numero de elementos a calcular: ");
            //almacena el valor de n
            n = Convert.ToInt32(Console.ReadLine());

            //se repite hasta que el caso sea contrario
            if(n <= 0){
                Console.WriteLine("Ingrese un número mayor de 0!");
                Console.Beep();
                Console.WriteLine("");
            }

            //en caso contrario(si es mayr de 0 procede el codigo)
            else{
                    //creamos un ciclo for para calcualr la serie
                for(int i = 1; i <= n; i++){
                    //esto calcual el producto de la izquierda
                    producto1 = ((2.0*i)/((2.0*i)-1.0));
                    //esto calcula el producto de la derecha
                    producto2 = ((2.0*i)/((2.0*i)+1.0));
                    //calculamos el resultado final y lo vamos sumando
                    resultado += (2*((producto1)*(producto2)));
                }

                //muestra al usuario el resultado
                Console.WriteLine("");
                Console.WriteLine("El resultado es: {0:N4}",resultado);
                Console.Beep();
            }
        }
    }
}



















