using System;
// Espacio de nombres 
namespace CS5
{
    class Program
    {
        static void Main(string[]args)
        {
            // Unidad 1: Estructuras de control II
            // Unidad 2: Funciones II
            // Sesión 12: Instrucción while 30092026
            // Sintaxis: while
            // inicialización;
            // while(expresión)
            // {
            //      bloque de instrucciones
            //      iterador;
            // }
            // Iterar: repetir
            // Ejemplo 1: Ciclo ascendente (rango: 1-3)
            int m = 1; // Inicialización
            while (m <= 3)
            {
                // Bloque de instrucciones
                Console.WriteLine($"m: {m}");
                m += 1; // Iterador
            }
            // Ejercitación
            // 1. Definir un ciclo para imprimir tu nombre 5 veces
            // Nota: Para la expresión, utilizar el operador <
            int n = 0;
            while(n < 5)
            {
                Console.WriteLine("Mi nombre es Diego Lavín");
                n += 1; // Iterador
            }
            // b. Ciclo descendente
            int d = 3;
            while(d >= 1)
            {
                Console.WriteLine($"d: {d}");
                d -= 1; // Iterador
            }
            // c. Incrementos
            // Secuencia: 3, 6 , 9, 12, 15, 18
            int i = 3;
            while(i <= 18)
            {
                Console.WriteLine($"i: {i}");
                i += 3; // Iterador
            }
            // d. Decrementos
            // Ejercitación
            // 1. Definir un ciclo para imprimir "331" 8 veces
            // Nota: Para la solución, definir un ciclo descendente con decrementos de 2 unidades
            int j = 16;
            while(j >= 2)
            {
                Console.WriteLine("331");
                j -= 2; // Iterador
            }
            // Actividad 1: Ciclo infinito
            // 1. Definir un ciclo infinito ascendente
            // 2. Definir un ciclo infinrito descendente
            // Nota: Para la solución, utilizar el operador de diferencia

            int f = 1;

            while (f > 0) 
            {
                Console.WriteLine(f);
                f++;
            }

            // Descendente

            int g = 99;

            while (g != 100) 
            {
                Console.WriteLine(g);
                g--;
            }
        }
    }
}