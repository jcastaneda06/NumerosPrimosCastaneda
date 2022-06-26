using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace NumerosPrimosSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool correr = true;
            int decision = 0;

            Console.WriteLine("###### FUNCION CONTADORA DE #PRIMOS ######");
            Console.WriteLine("####### METODO INTEGRAL DE RIEMANN #######");
            Console.WriteLine("############# V1.3 EDUCATIVA #############");
            Console.WriteLine("#### JESUS ALBERTO CASTAÑEDA GONZALEZ ####");
            Console.WriteLine("############# +507 6231-9187 #############");
            Console.WriteLine("########## irojacastag@gmail.com #########");

            while (correr)
            {
                bool pregunta = true;
                int X = 0;
                int Jf = 0;
                int If = 0;
                int j = 0;
                int i = 0;
                int ii = 0;
                int Jffi = 0;
                int Jfi = 0;
                int Jii = 0;
                int J = 0;
                int Pix = 0;
                int Piq = 0;
                int y = 0; // y = f(J2-J1) para la Integral, i = f(J)
                int Pj = 0;
                int Pn = 0;
                int Co = 0;
                int Riemann = 0;
                /*gfokhkerg
                 hertert
                herth
                ertherth
                */
                Console.WriteLine("Introduzca X para pi(X) \nX = ");
                X = Convert.ToInt32(Console.ReadLine());

                If = (int)(Math.Round(Convert.ToDouble((2 * Math.Sqrt(X) - 3) / 6)));
                Jf = (int)(Math.Round((2 * X - 6 - Math.Pow(-1, X)) / 6));
                int[] P = new int[X];
                Piq = Jf;
                Jffi = (int)Math.Floor(Convert.ToDouble(Jf / 5)); // OJO CON ESTE 5 CUANDO META EL RANGO INICIAL 

                Stopwatch sw = new Stopwatch();

                sw.Start(); //DEBE CONTAR LOS SEGUNDOS DE LA CARGA DEL ARREGLO O LISTA P[j]
                for (j = 1; j <= Jf; j++)
                {
                    P[j] = (int)(6 * j + 3 - Math.Pow(-1, j)) / 2;
                }

                var Q = new List<int>();
                var Qp = new List<int>();
                var JF = new List<int>();
                var JFfi = new List<int>();
                int respuesta = 0;
                try
                {
                    Console.WriteLine("Desea imprimir los valores cada iteracion?\n1. Si");
                    respuesta = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Introduccion no valida. No se imprimira por iteración.");
                }
                //sw.Start();
                for (i = 1; i <= If; i++)
                {
                    if (P[i] != 0)
                    {
                        Jfi = (int)Math.Floor(Convert.ToDouble(Jf / P[i]));
                        Jii = i;
                        ii += 1;

                        for (j = Jii; j <= Jfi; j++)
                        {
                            if (P[j] == 0)
                            {
                                continue;
                            }
                            Pj = P[i] * P[j];
                            Q.Add(Pj);
                            Pn += 1;
                            y += 1;

                            if (respuesta == 1) //ACTIVAR SOLO EN CASO DE REVISION DEL CODIGO O PARA UNA MEJOR COMPRENSION DE RESULTADOS CON OBJETIVO DIDACTICO
                            {
                            Console.WriteLine("i = {0} | j = {1} | P(i) = {2}  | P(j) = {3}  | Pj = {4}", i, j, P[i], P[j], Pj);
                            Console.WriteLine("------------------------------------------------------------------------------");
                            }
                        }

                        if (Pj > X)
                        {
                            Pn -= 1;
                            y -= 1;
                        }

                        foreach (int q in Q)
                        {
                            J = Convert.ToInt32(Math.Round((2.0 * q - 3) / 6));
                            P[J] = 0;
                        }

                        //JF.Add(Piq);    //DESACTIVADO PARA MEDIR VELOCIDAD
                        //JFfi.Add(Jffi); //DESACTIVADO PARA MEDIR VELOCIDAD
                        //Qp.Add(y);      //DESACTIVADO PARA MEDIR VELOCIDAD
                        Jffi = y + (ii - 1);                    
                        
                        if (Jffi >= ii)
                        {
                            if (respuesta == 1)
                            {
                                Console.WriteLine("--------------------------------------------------------------------");
                                Console.WriteLine("i = {0} | jii = {1}  |  Jfi = {2}| Jf = {3}  | i=f(J)=(J2-J1) = {4}", ii, ii, Jffi, Piq, y);
                                Console.WriteLine("--------------------------------------------------------------------");
                            }

                            Piq = Piq - y;
                            y = 0;
                            Q.Clear();
                        }
                        {
                            Riemann = Piq - y;
                        }
                    }
                }
                if (X == 1)
                {
                    Co = 0;
                }
                if (X == 2)
                {
                    Co = 1;
                }
                if (X >= 3)
                {
                    Co = 2;
                }
                
                Pix = Jf - Pn + Co;

                Console.WriteLine("          X = {0}", X);
                Console.WriteLine("          pi(x) Integral de Riemann = {0}", Riemann); // Resto después de la Integral
                Console.WriteLine("          pi(x) = {0}", Pix); // Ecuación Jf - J(x) + 2
                Console.WriteLine("          Jx = {0}", Pn); // Suma de todas las celdas eliminadas
                Console.WriteLine("          pi(x) Lista = {0}", Piq); // #Primos restantes en la lista
                sw.Stop();
                Console.WriteLine("          Tiempo de ejecución: {0}", sw.Elapsed);
                Console.WriteLine("--------------------------------------------------------------------");

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
