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

            Console.WriteLine("###### FUNCIÓN CONTADORA DE #PRIMOS ######");
            Console.WriteLine("####### MÉTODO INTEGRAL DE RIEMANN #######");
            Console.WriteLine("############# v1.5 EDUCATIVA #############");
            Console.WriteLine("#### JESÚS ALBERTO CASTAÑEDA GONZÁLEZ ####");
            Console.WriteLine("############# +507 6231-9187 #############");
            Console.WriteLine("########## irojacastag@gmail.com #########");

            while (correr)
            {
                bool pregunta1 = true;
                bool pregunta2 = true;
                bool pregunta3 = true;
                int respuesta1 = 0;
                int respuesta2 = 0;
                int respuesta3 = 0;
                int X = 0;
                int If = 0;
                int Jf = 0;
                int Jfi = 0;
                int J = 0;
                int Pj = 0;
                int i = 0;
                int j = 0;
                int k = 0;
                int Dimensionar = 0;
                int Pn = 0;
                int Piq = 0;
                int Pix = 0;
                int Jffi = 0;
                int y = 0; // y = f(J2-J1) para la Integral, i = f(J)
                int ii = 0;
                int Riemann = 0;
                int Co = 0;
                int Jii = 0;
                int bin = 0;

                Console.WriteLine("Introduzca X para pi(X) \nX = ");
                X = Convert.ToInt32(Console.ReadLine());

                If = (int)(Math.Round(Convert.ToDouble((2 * Math.Sqrt(X) - 3) / 6)));
                Jf = (int)(Math.Round((2 * X - 6 - Math.Pow(-1, X)) / 6));
                var Q = new List<int>();
                Dimensionar = (int)(Math.Round(Convert.ToDouble((X))));
                int[] P = new int[Dimensionar];
                Piq = Jf;
                Jffi = (int)Math.Floor(Convert.ToDouble(Jf / 5)); 

                
                try
                {
                    Console.WriteLine("Desea imprimir los cálculos paso a paso cada iteración P(i) * P(j)?\n1. Si");
                    respuesta1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" Estamos calculando...... Se imprimirá cálculos pasa a paso cada iteración P(i) * P(j) ");
                }
                catch (Exception)
                {
                    Console.WriteLine("Estamos calculando...... Solo se imprimirá pi(x) y J(x)");
                }

                Stopwatch sw = new Stopwatch();

                sw.Start(); 
                for (j = 1; j <= Jf; j++)                         
                {
                    P[j] = (int)(6 * j + 3 - Math.Pow(-1, j)) / 2;
                }

                for (i = 0; i <= If; i++)
                {
                    if (Jffi >= ii)
                    {
                        if (P[i] != 0)
                        {
                            Jfi = (int)Math.Floor(Convert.ToDouble(Jf / P[i]));
                            Jii = i;
                            ii += 1;
                            for (j = Jii; j <= Jfi; j++) // Reemplazo Jii por i, cuando se incluy RANGO volverá ser Jii
                            {
                                if (P[j] != 0)
                                {
                                    Pj = P[i] * P[j];
                                    Q.Add(Pj);
                                    Pn += 1;
                                    y += 1;
                                    /*
                                    if (respuesta1 == 1) //ACTIVAR SOLO EN CASO DE REVISION DEL CODIGO O PARA UNA MEJOR COMPRENSION DE RESULTADOS CON OBJETIVO DIDACTICO
                                    {
                                        if (Pj <= X)
                                        {
                                        Console.WriteLine("------------------------------------------------------------------------------");
                                        Console.WriteLine("i = {0} | j = {1} | P(i) = {2}  | P(j) = {3}  | Pj = {4}", i, j, P[i], P[j], Pj);
                                        Console.WriteLine("------------------------------------------------------------------------------");
                                        }
                                    }*/
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
                            Q.Clear(); 
                            
                            if (Jffi >= ii)
                            {
                                Jffi = y + (ii);
                                if (respuesta1 == 1)
                                {
                                    Console.WriteLine("--------------------------------------------------------------------");
                                    Console.WriteLine("i = {0} | jii = {1}  |  Jfi = {2}| Jf = {3}  | i=f(J)=(J2-J1) = {4}", ii, ii, Jffi, Piq, y);
                                    Console.WriteLine("--------------------------------------------------------------------");
                                }
                                Piq = Piq - y;
                                y = 0;
                            }
                        }
                    }  
                }
                Riemann = Piq - y;

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

                    Console.WriteLine("          X = {0}", X);
                    Pix = Jf - Pn + Co;
                    Console.WriteLine("          pi(x) = {0}", Pix); // Ecuación Jf - J(x) + 2
                    Console.WriteLine("          J(x) = {0}", Pn); // Suma de todas las celdas eliminadas
                    Console.WriteLine("          pi(x) Integral de Riemann = {0}", Riemann); // Resto después de la Integral
                    Console.WriteLine("          pi(x) Lista = {0}", Piq); // #Primos restantes en la lista
                    
                    sw.Stop();
                    Console.WriteLine("          Tiempo de ejecución: {0}", sw.Elapsed);
                    Console.WriteLine("--------------------------------------------------------------------");

                //*****************************************************************************************************************************************
                //OPCION PARA IMPRIMIR LOS NUMEROS PRIMOS P(i) <= X

                Console.WriteLine("¿Deesa imprimir Lista de Números Primos <= X? \n1. Si \n2. No");
                //respuesta2 = true;
                while (pregunta2)
                {
                    try
                    {
                        respuesta2 = Convert.ToInt32(Console.ReadLine());
                        pregunta2 = false;
                    }
                    catch
                    {
                        Console.WriteLine("Incorrecto. Introduzca un valor entre 1 y 2.");
                    }
                }


                if (respuesta2 == 1)
                {
                    Console.WriteLine("Se imprimirá Tabla de Números Primos <= X");
                    
                    Console.WriteLine("     X = {0}             | pi(x) = {1}", 1, 2);
                    Console.WriteLine("     X = {0}             | pi(x) = {1}", 2, 3);
                    j = 2;
                    foreach (int p in P)
                    {
                        if (p != 0)
                        {
                            j = j + 1;
                            Console.WriteLine("     X = {0}             | pi(x) = {1}", j, p);
                        }
                    }
                }

                //*****************************************************************************************************************************************
                //OPCION PARA IMPRIMIR TABLA PARA GRAFICAR LA FUNCION Pi(x) = f(x)

                Console.WriteLine("¿Deesa imprimir Tabla para Graficar la Función pi(x) = f(x)? \n1. Si \n2. No");
                //respuesta3 = true;
                while (pregunta3)
                {
                    try
                    {
                        respuesta3 = Convert.ToInt32(Console.ReadLine());
                        pregunta3 = false;
                    }
                    catch
                    {
                        Console.WriteLine("Incorrecto. Introduzca un valor entre 1 y 2.");
                    }
                }

                if (respuesta3 == 1)
                {
                    Console.WriteLine("Estamos calculando...... Se imprimirá Tabla de Datos para Graficar la Función pi(x) = f(x)");
                    var máximo = P.Max(); //P.ElementAt(P.Count()); //SE DEBE CAMBIAR P.ElementAt para seleccionar P máxima
                    int kTemporal = 1;
                    Pix = 0;
                    foreach (int p in P)
                    {
                        for (k = kTemporal; k <= X; k++)
                        {
                            bin = 0;
                            if (k >= 4)
                            {
                                if (k > p)
                                {
                                    if (k >= máximo)// AQUI
                                    {
                                        bin = 0;
                                    }
                                    else
                                    {
                                        bin = 0;
                                        kTemporal = k;
                                        break;
                                    }
                                }
                                else
                                {
                                    if (k < p)
                                    {
                                        bin = 0;
                                    }
                                    else
                                        if (k == p)
                                    {
                                        bin = 1;
                                    }

                                }
                        
                                Pix = Pix + bin;
                                Console.WriteLine("     X = {0}             | pi(x) = {1}", k, Pix);

                            }
                            else
                            {
                                if (k == 1)
                                {
                                    bin = 0;
                                }
                                else
                                {
                                    bin = 1;
                                }
                                Pix = Pix + bin;
                                Console.WriteLine("     X = {0}             | pi(x) = {1}", k, Pix);
                            }
                        }
                    }
                }

                //**************************************************************

                Console.WriteLine("¿Quiere volver a calcular para otro valor dado X? \n1. Si \n2. No");
                while (pregunta1)
                {
                    try
                    {
                        decision = Convert.ToInt32(Console.ReadLine());
                        switch (decision)
                        {
                            case 1:
                                pregunta1 = false;
                                break;

                            case 2:
                                correr = false;
                                pregunta1 = false;
                                break;

                            default:
                                Console.WriteLine("Introduzca un número entre 1 y 2. 1. Continúar con el programa \n2. Salir");
                                break;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Incorrecto. Elija 1 para continuar o 2 para salir.");
                    }
                }
            }
        }
    }
}
