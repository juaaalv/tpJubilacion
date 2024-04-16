using System;
using System.ComponentModel.Design;

namespace TP_Jubilacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edadUsuario = IngresoEdad("Ingrese su edad");
            char generoUsuario = IngresoGenero("Ingrese su género (F o M)");

            string mensajeAUsuario= mePuedoJubilar(edadUsuario, generoUsuario, "Te podés jubilar :)", "Todavía no te podés jubilar");

            Console.WriteLine(mensajeAUsuario);
        }

        static int IngresoEdad(string mensaje)
        {
            Console.WriteLine(mensaje);
            return int.Parse(Console.ReadLine());
        }

        static char IngresoGenero(string mensaje)
            {
            Console.WriteLine(mensaje);
            return char.Parse(Console.ReadLine());
            }
        static string mePuedoJubilar(int edad, char genero, string mensajeSi, string mensajeNo)
        {
            const char mujer = 'F';
            const char hombre = 'M';

            if ((edad >= 60 && genero == mujer) || (edad >= 65 && genero == mujer))
            {
                return (mensajeSi);
            }
             return (mensajeNo);
        }
     }
}
