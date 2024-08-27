using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Elige el ejercicio a ejecutar (1, 2, 3, etc):");
        string opcion = Console.ReadLine()!;

        switch(opcion)
        {
            case "1":
                HolaNombre saludo = new HolaNombre();
                saludo.Saludar();  
                break;
            case "2":
                Suma1 suma = new Suma1();
                suma.Sumar1();
                break;
            case "3":
                Suma2 suma2 = new Suma2();
                suma2.Sumar2();
                break;
            case "4":
                Producto multiplicar = new Producto();
                multiplicar.Multiplicar();
                break;
            case "5":
               Resta restar = new Resta();
               restar.Restar();
               break;
            case "6":
               Division dividir = new Division();
               dividir.Dividir();
               break;
            case "7":
               Operacion1 operacion1 = new Operacion1();
               operacion1.Funcion1();
               break;
            case "8":
               Operacion2 operacion2 = new Operacion2();
               operacion2.Funcion2();
               break;
            case "9":
               Operacion3 operacion3 = new Operacion3();
               operacion3.Funcion3();
               break;
            case "10":
               Operacion4 operacion4 = new Operacion4();
               operacion4.Funcion4();
               break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}
