using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace Clase_03_ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 Una empresa constructora necesita calcular el área de un terreno rectangular.
            //Pide al usuario que ingrese la base y la altura en metros, y muestra el área
            //total


            //Console.WriteLine("Ingrese su altura: ");
            //double altura = double.Parse(Console.ReadLine());

            //Console.WriteLine("Ïngrese su base: ");
            //double Base = double.Parse(Console.ReadLine());

            //double area = Base * altura;

            //Console.WriteLine($"Su area es: {area}");


            //  Un docente desea calcular el promedio de tres notas de un estudiante. Solicita
            //las tres calificaciones y muestra el promedio final.


            //Console.WriteLine("Ïngrese su primera nota: ");
            //double nota1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Ïngrese su segunda nota: ");
            //double nota2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Ïngrese su tercera nota: ");
            //double nota3 = double.Parse(Console.ReadLine());

            //double notaF = (nota1 + nota2 + nota3) / 3;


            //Console.WriteLine($"Su nota final es: {notaF}");



            //Una aplicación meteorológica debe convertir una temperatura de grados
            //Celsius a Fahrenheit. Pide al usuario que ingrese la temperatura en Celsius y
            //muestra el resultado en Fahrenheit.

            //Console.WriteLine("Ïngrese su temperatura en celsius °C: ");
            //double celsius = double.Parse(Console.ReadLine());

            //double Fahrenheit = (celsius * 9 / 5) + 32;

            //Console.WriteLine($"Su temperatura de celcius ah Fahrenheit es: {Fahrenheit}°F ");


            // Un turista desea saber cuántos colones recibirá por una cantidad en dólares.
            //La tasa de cambio actual es de 8.75.Solicita al usuario la cantidad en dólares
            //y muestra el equivalente en colones.


            //Console.WriteLine("Ingrese su cantidad en dolares: ");
            //double dolares = double.Parse(Console.ReadLine());

            //double colones = (dolares * 8.75);
            //Console.WriteLine($"Sus dolares ha colones son: {colones}");



            //Una aplicación de salud necesita calcular cuántos meses y días ha vivido una
            //persona.Pide al usuario que ingrese su edad en años y muestra la cantidad
            //aproximada de meses y días vividos.

            //Console.WriteLine("Ingrese su edad: ");
            //int edad = int.Parse(Console.ReadLine());

            //int meses = edad * 12;
            //int dias = edad * 365;
            //Console.WriteLine($"Has vivido aproximadamente {meses} meses o {dias} dias");


            //Un ingeniero debe calcular el perímetro de un terreno con forma de triángulo.
            //Solicita al usuario que ingrese las medidas de los tres lados y muestra el
            //perímetro total.




            //Console.WriteLine("Ïngrese su primer lado: ");
            //double lado1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Ïngrese su segundo lado: ");
            //double lado2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Ïngrese su tercer lado: ");
            //double lado3 = double.Parse(Console.ReadLine());

            //double perimetro = (lado1 + lado2 + lado3);
            //Console.WriteLine($"El perimetro es: {perimetro}");




            //Un programa educativo requiere mostrar el cuadrado y la raíz cuadrada de un
            //número ingresado por el usuario. Solicita el número y muestra ambos
            //resultados.

            Console.WriteLine("Ïngrese su numero: ");
            double numero = double.Parse(Console.ReadLine());

            double cuadrado = numero * numero;
            double raizCuadrada = Math.Sqrt(numero);

            Console.WriteLine($"El cuadrado de su numero es: {cuadrado}");
            Console.WriteLine($"La raiz cuadrada es: {raizCuadrada}");








        }
    }
}
