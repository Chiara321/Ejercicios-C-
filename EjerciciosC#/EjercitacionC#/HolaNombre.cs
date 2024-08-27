using System;

public class HolaNombre {
    public void Saludar(){
        Console.WriteLine("Escriba su nombre a continuación:");
        string nombre = Console.ReadLine()!;
        Console.WriteLine("Hola " + nombre);
    }
}