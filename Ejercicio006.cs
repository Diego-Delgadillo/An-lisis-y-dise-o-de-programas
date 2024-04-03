//Ejercicio 006
/*
Generar un programa del juego de adivinanzas, en el que la computadora generará un número
aleatorio entre 0 y 10 y le dará pistas al usuario como si es mayor o menor al número que vaya
ingresando; otorgarle solamente 5 oportunidades al usuario de adivinar

*/
using System;

public class Program{
    public static void Main(){
        // declaro las variables a utilizar
        int numeroIngresado;
        int intentos = 5;

       //Con esta funcion creamos una variable de tipo var y le asignamos la funcion random
        var numeroAleatorio = new Random();
         //Con esta funcion de Next()  asignamos un numero aletorio entre el rango especificado (0 y 10)
        var valorNumeroAleatorio = numeroAleatorio.Next(0,10);

        //Hacemos uso de la funcion "Next()" para genera run nuumero aletorio 


        //solcita el numero
        Console.WriteLine("Este programa genera un número aleatorio entre 0 y 10 y tiene 5 oportunidades para adivinarlo\n");
        Console.WriteLine("Ingrese el número sugerido: ");
        Console.WriteLine("");
        //Convierte la entrada ingresada y lo almacena en la variable
        numeroIngresado = Convert.ToInt32(Console.ReadLine());


        //Creamos el ciclo para llevar un control de oportunidades
        for(int i = 0; i <= intentos; i++){

            //condicion para cuando el numero es mayor que el aleatorio 
            if(numeroIngresado > valorNumeroAleatorio){
                Console.WriteLine("EL número es menor que: {0}",numeroIngresado);
                Console.WriteLine("");
                Console.WriteLine("Ingrese otro número: ");
                //Convierte la entrada ingresada y lo almacena en la variable
                numeroIngresado = Convert.ToInt32(Console.ReadLine());
            }

            //en caso contrario indica que es menor
            else{
                Console.WriteLine("El número es mayor que: {0}",numeroIngresado);
                Console.WriteLine("");
                Console.WriteLine("Ingrese otro número: ");
                //Convierte la entrada ingresada y lo almacena en la variable
                numeroIngresado = Convert.ToInt32(Console.ReadLine());
            }

            //Condicion para cuando se adivina el numero 
            if(numeroIngresado == valorNumeroAleatorio){
                //mensaje de ganador
                Console.WriteLine("Usted adivinó el número en {0} intentos!",i+1);
                //alerta de sonido
                Console.Beep();
                //sale del ciclo for 
                break;
            }
        }

    }
}