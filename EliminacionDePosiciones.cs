using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;

namespace NumerosPrimosSharp
{
    internal class EliminacionDePosiciones
    {
        static void Main(string[] args)
        {
            bool correr = true;
            int decision = 0;

            Console.WriteLine("############################### FUNCION CONTADORA DE PRIMOS #################################");
            Console.WriteLine("######################### METODO ELIMINACION DE POSICION CASTAÑEDA ##########################");
            Console.WriteLine("###################################### +507 6231-9187 #######################################");
            Console.WriteLine("################################## irojacastag@gmail.com ####################################");

            while (correr)
            {
                bool pregunta = true;
                int X = 0;
                int Kx = 0;
                int Ix = 0;
                int k = 0;
                int i = 0;
                int j = 0;
                int Jxi = 1;
                int Jii = 1;
                int J = 0;
                int Pix = 0;
                int Pj = 0;
                int Ci = 0;
                int Co = 0;
                int Pc = 0;

                Console.WriteLine("Introduzca X para pi(X) \nX = ");
                X = Convert.ToInt32(Console.ReadLine());

                var P = new List<int>();
                Kx = (int)(Math.Round((2 * X - 6 - Math.Pow(-1, X)) / 6));
                //Qx = (int)(Math.Floor(Math.Sqrt(X)));
                Ix = (int)(Math.Floor(Convert.ToDouble((2 * Math.Sqrt(X) - 3) / 6)));


                //int Ji(Ix)				Variable arreglo
                //int Jf(Ix)				Variable arreglo
                Stopwatch sw = new Stopwatch();

                for (k = 1; k <= Kx; k++)
                {
                    P.Add((int)(6 * k + 3 - Math.Pow(-1, k)) / 2);
                }

                int m = 0;
                int n = 0;
                int Pn = 0;

                var Q = new List<int>();
                int respuesta = 0;
                try
                {
                    Console.WriteLine("Desea imprimir los valores cada iteracion?\n1. Si");
                    respuesta = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Introduccion no valida. No se imprimira por iteracion.");
                }
                sw.Start();
                for (i = 1; i <= Ix; i++)
                {
                    Jxi = (int)Math.Floor(Convert.ToDouble(Kx / P[i] - Ci));    //Se debe redondear Jxi al menor valor con cero decimales
                    Jii = i;
                    for (k = Jii; k <= Jxi; k++)
                    {
                        Pj = P[i] * P[k];
                        //J = Convert.ToInt32(Math.Round((2.0 * Pj - 3) / 6));    //Se debe redondear J al valor con cero decimales
                        Q.Add(Pj);
                        Pn += 1;
                        if (respuesta == 1)
                        {
                            Console.WriteLine("i = {0} | k = {1} | Pk = {2} | J = {3}", i, k, Pj, J);
                            Console.WriteLine("----------------------------------------");
                        }
                        //Console.ReadLine();

                    }
                    if (Pj > X)
                    {
                        Pn -= 1;
                    }
                    
                    Co = (int)(Math.Floor(Convert.ToDouble(Kx / P[i+1])));
                    Pc = (int)(6 * Co + 3 - (Math.Pow(-1, Co))) / 2;
                    Ci = (int)(Math.Floor(Convert.ToDouble((2 * Pc - 3 * P[i] - P[i]) / (6 * P[i]))));

                    foreach (int q in Q)
                    {
                        //J = Convert.ToInt32(Math.Round((2.0 * q - 3) / 6));
                        P.Remove(q);
                    }
                    Q.Clear();
                    
                }
                Pix = Kx - Pn + 2;
                Console.WriteLine("pi(X) = {0}", Pix);
                Console.WriteLine("Jx = {0}", Pn);
                sw.Stop();
                Console.WriteLine("Tiempo de ejecucion: {0}", sw.Elapsed);
                Console.WriteLine("----------------------------------------");

                Console.WriteLine("¿Quiere volver a calcular? \n1. Si \n2. No");
                while (pregunta)
                {
                    try
                    {
                        decision = Convert.ToInt32(Console.ReadLine());
                        switch (decision)
                        {
                            case 1:
                                pregunta = false;
                                break;

                            case 2:
                                correr = false;
                                pregunta = false;
                                break;

                            default:
                                Console.WriteLine("Introduzca un numero entre 1 y 2. 1. Continuar con el programa \n2. Salir");
                                break;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Entrada no valida. Elija 1 para continuar o 2 para salir.");
                    }
                }
            }
        }
    }
}
