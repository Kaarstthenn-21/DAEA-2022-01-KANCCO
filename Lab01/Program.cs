using System;

namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Resta de dos enteros");
                Console.WriteLine("[4] Multiplicacion de dos enteros");
                Console.WriteLine("[5] Division de dos numeros");
                Console.WriteLine("[6] Primeros numeros primos");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int R1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int R2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La Resta de {0} y {1} es {2}", R1, R2, Resta(R1, R2));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int M1= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int M2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La Multiplicacion de {0} y {1} es {2}", M1, M2, Multiplicacion(M1, M2));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        int D1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int D2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La Division de {0} y {1} es {2}", D1, D2, Division(D1, D2));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Ingrese el primer número");
                        int N1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Los primeros {0} numeros primos son: ", N1);
                        nPrimos(N1);
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));
        }

        static int Suma(int a, int b)
        {
            return a + b;
        }
        static int Resta(int a, int b)
        {
            return a - b;
        }

        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        static double Division(int a, int b)
        {
            if(a != 0 && b != 0)
            {
                return a / b;

            }else if(a != 0 || b!= 0)
            {
                return a / b;

            }else
            {
                return 0.0;
            }
        }

        static void Raiz()
        {
            for(int i = 1; i< 10; i++)
            {
                Console.WriteLine("La raiz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        static void nPrimos(int a)
        {
            //variable que contiene el numero que se está probando
            int n = 2;
            //variable que contiene el total de numeros primos encontrados
            int total = 1;

            //iterar mientras el total de numeros primos no se mayor a 100
            while (total <= a)
            {

                //variable que indica si un numero es primo o no
                bool esPrimo = true;

                //se divide el numero (n) entre todos los numeros anterios a el
                //si el modulo de la division es 0 significa que el numero no es primo
                //y se marca la variable esPrimo = false y se termina el ciclo for
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }

                }

                //si despues de ejecutar el ciclo for la variable esPrimo sigue
                //teniendo un valor true entonces se imprime el numero y se incrementa
                // el contador de numeros encontrados total++
                if (esPrimo)
                {
                    Console.WriteLine(n);
                    total++;
                }
                //se incrementa para evaluar el siguiente número
                n++;
            }
        }
        static void centigradosToFareignkey(double t)
        {
            double Tfareign = ((9 * t) / 5) + 5;
            Console.WriteLine($"{t} centigrados es igual a {Tfareign} grados FareignKey");
        }

        static void fareignkeyToCentigrados(double t)
        {
            double centigrados = (5 * (t - 32)) / 9;
            Console.WriteLine($"{t} grados FareignKey es igual a {centigrados} grados Centigrados");
        }
    }
}
