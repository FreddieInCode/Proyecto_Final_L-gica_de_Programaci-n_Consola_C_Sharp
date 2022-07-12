using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Lógica_de_Programación_Consola_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cur = new string[8];
            string[] prof = new string[8];

            char continuar;

            
            do
            {
                //             -------------------------------CURSO Y PROFE-------------------------------------
                for (int i = 0; i < 8; i++)
                {
                    Console.WriteLine($"---------------------CURSO Y PROFESOR {i + 1}--------------------");
                    Console.WriteLine("Ingrese el curso " + (i + 1) + ": ");
                    cur[i] = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el nombre del profesor " + (i + 1) + ": ");
                    prof[i] = Console.ReadLine();
                    Console.WriteLine("");
                }


                //             -------------------------------5 ESTUDIANTES-------------------------------------
                string[] nom = new string[5];


                // --------------DATOS ALUMNO [0] -------------------

                //CANTIDAD DE CURSOS DEL ALUMNO [0] 
                double[] curalum0 = new double[8];

                //LABORATORIOS(10) DE CADA CURSO DEL ALUMNO [0]
                double[] labAlum0Cur0 = new double[10];
                double[] labAlum0Cur1 = new double[10];
                double[] labAlum0Cur2 = new double[10];
                double[] labAlum0Cur3 = new double[10];
                double[] labAlum0Cur4 = new double[10];
                double[] labAlum0Cur5 = new double[10];
                double[] labAlum0Cur6 = new double[10];
                double[] labAlum0Cur7 = new double[10];

                //Los promedios de los Cursos del alumno [0]: 
                double[] Alum0CursosPromfin = new double[8];

                //Console.Clear();
                // -------------------------------------------------------------SOLO ALUMNO [0] 
                Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("");
                Console.WriteLine($"---------------------DATOS DEL ESTUDIANTE 1--------------------");
                Console.Write($"Nombre del estudiante 1: ");
                nom[0] = Console.ReadLine();
                Console.WriteLine("");

                //DECLARO INDEX PARA SABER QUE ALUMNO ES 
                string value0 = nom[0];
                int index0 = Array.IndexOf(nom, value0);

                // ----------------------------------------------------------------------- PREGUNTO INDEX
                if (index0 == 0)
                {
                    //repite la cantidad de cursos (8)
                    for (double k = 0; k < curalum0.Length; k++)
                    {
                        // ---------------- DENTRO DEL CURSO 0 
                        if (k == 0)
                        {
                            Console.WriteLine($"---------------------CURSO {k + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas de los laboratorios del curso de " + cur[0] + ": ");
                            double suma = 0;
                            //el curso 0 repetira los 10 laboratorios de ese curso ---CERO---
                            for (int a = 0; a < labAlum0Cur0.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum0Cur0[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum0Cur0[a] < 0)
                                {
                                    labAlum0Cur0[a] = 0;
                                }
                                else if (labAlum0Cur0[a] > 20)
                                {
                                    labAlum0Cur0[a] = 20;
                                }

                                suma += labAlum0Cur0[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[0] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum0Cur0 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum0Cur0 < 0)
                            {
                                examAlum0Cur0 = 0;
                            }
                            else if (examAlum0Cur0 > 20)
                            {
                                examAlum0Cur0 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum0Cur0) * 0.8);

                            Alum0CursosPromfin[0] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[0] + " es: " + Alum0CursosPromfin[0]);
                            // PROMEDIO ES : Alum0CursosPromfin[0]   
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //----------------DENTRO DEL CURSO 1
                        else if (k == 1)
                        {
                            Console.WriteLine($"---------------------CURSO {k + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[1] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 1 repetira los 10 laboratorios de ese curso ---UNO---
                            for (int a = 0; a < labAlum0Cur1.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum0Cur1[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum0Cur1[a] < 0)
                                {
                                    labAlum0Cur1[a] = 0;
                                }
                                else if (labAlum0Cur1[a] > 20)
                                {
                                    labAlum0Cur1[a] = 20;
                                }

                                suma += labAlum0Cur1[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[1] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum0Cur1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum0Cur1 < 0)
                            {
                                examAlum0Cur1 = 0;
                            }
                            else if (examAlum0Cur1 > 20)
                            {
                                examAlum0Cur1 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum0Cur1) * 0.8);

                            Alum0CursosPromfin[1] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[1] + " es: " + Alum0CursosPromfin[1]);
                            // PROMEDIO ES : Alum0CursosPromfin[1] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //----------------DENTRO DEL CURSO 1
                        else if (k == 2)
                        {
                            Console.WriteLine($"---------------------CURSO {k + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[2] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 2 repetira los 10 laboratorios de ese curso ---DOS---
                            for (int a = 0; a < labAlum0Cur2.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum0Cur2[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum0Cur2[a] < 0)
                                {
                                    labAlum0Cur2[a] = 0;
                                }
                                else if (labAlum0Cur2[a] > 20)
                                {
                                    labAlum0Cur2[a] = 20;
                                }

                                suma += labAlum0Cur2[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[2] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum0Cur2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum0Cur2 < 0)
                            {
                                examAlum0Cur2 = 0;
                            }
                            else if (examAlum0Cur2 > 20)
                            {
                                examAlum0Cur2 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum0Cur2) * 0.8);

                            Alum0CursosPromfin[2] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[2] + " es: " + Alum0CursosPromfin[2]);
                            // PROMEDIO ES : Alum0CursosPromfin[2] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //----------------DENTRO DEL CURSO 3
                        else if (k == 3)
                        {
                            Console.WriteLine($"---------------------CURSO {k + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[3] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 3 repetira los 10 laboratorios de ese curso ---TRES---
                            for (int a = 0; a < labAlum0Cur3.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum0Cur3[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum0Cur3[a] < 0)
                                {
                                    labAlum0Cur3[a] = 0;
                                }
                                else if (labAlum0Cur3[a] > 20)
                                {
                                    labAlum0Cur3[a] = 20;
                                }

                                suma += labAlum0Cur3[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[3] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum0Cur3 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum0Cur3 < 0)
                            {
                                examAlum0Cur3 = 0;
                            }
                            else if (examAlum0Cur3 > 20)
                            {
                                examAlum0Cur3 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum0Cur3) * 0.8);

                            Alum0CursosPromfin[3] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[3] + " es: " + Alum0CursosPromfin[3]);
                            // PROMEDIO ES : Alum0CursosPromfin[3] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 4
                        else if (k == 4)
                        {
                            Console.WriteLine($"---------------------CURSO {k + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[4] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 4 repetira los 10 laboratorios de ese curso ---CUATRO---
                            for (int a = 0; a < labAlum0Cur4.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum0Cur4[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum0Cur4[a] < 0)
                                {
                                    labAlum0Cur4[a] = 0;
                                }
                                else if (labAlum0Cur4[a] > 20)
                                {
                                    labAlum0Cur4[a] = 20;
                                }

                                suma += labAlum0Cur4[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[4] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum0Cur4 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum0Cur4 < 0)
                            {
                                examAlum0Cur4 = 0;
                            }
                            else if (examAlum0Cur4 > 20)
                            {
                                examAlum0Cur4 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum0Cur4) * 0.8);

                            Alum0CursosPromfin[4] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[4] + " es: " + Alum0CursosPromfin[4]);
                            // PROMEDIO ES : Alum0CursosPromfin[4] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 5
                        else if (k == 5)
                        {
                            Console.WriteLine($"---------------------CURSO {k + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[5] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 5 repetira los 10 laboratorios de ese curso ---CINCO---
                            for (int a = 0; a < labAlum0Cur5.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum0Cur5[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum0Cur5[a] < 0)
                                {
                                    labAlum0Cur5[a] = 0;
                                }
                                else if (labAlum0Cur5[a] > 20)
                                {
                                    labAlum0Cur5[a] = 20;
                                }

                                suma += labAlum0Cur5[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[5] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum0Cur5 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum0Cur5 < 0)
                            {
                                examAlum0Cur5 = 0;
                            }
                            else if (examAlum0Cur5 > 20)
                            {
                                examAlum0Cur5 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum0Cur5) * 0.8);

                            Alum0CursosPromfin[5] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[5] + " es: " + Alum0CursosPromfin[5]);
                            // PROMEDIO ES : Alum0CursosPromfin[5] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 6
                        else if (k == 6)
                        {
                            Console.WriteLine($"---------------------CURSO {k + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[6] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 6 repetira los 10 laboratorios de ese curso ---SEIS---
                            for (int a = 0; a < labAlum0Cur6.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum0Cur6[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum0Cur6[a] < 0)
                                {
                                    labAlum0Cur6[a] = 0;
                                }
                                else if (labAlum0Cur6[a] > 20)
                                {
                                    labAlum0Cur6[a] = 20;
                                }

                                suma += labAlum0Cur6[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[6] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum0Cur6 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum0Cur6 < 0)
                            {
                                examAlum0Cur6 = 0;
                            }
                            else if (examAlum0Cur6 > 20)
                            {
                                examAlum0Cur6 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum0Cur6) * 0.8);

                            Alum0CursosPromfin[6] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[6] + " es: " + Alum0CursosPromfin[6]);
                            // PROMEDIO ES : Alum0CursosPromfin[6] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 7
                        else if (k == 7)
                        {
                            Console.WriteLine($"---------------------CURSO {k + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[7] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 7 repetira los 10 laboratorios de ese curso ---SIETE---
                            for (int a = 0; a < labAlum0Cur7.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum0Cur7[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum0Cur7[a] < 0)
                                {
                                    labAlum0Cur7[a] = 0;
                                }
                                else if (labAlum0Cur7[a] > 20)
                                {
                                    labAlum0Cur7[a] = 20;
                                }

                                suma += labAlum0Cur7[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[7] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum0Cur7 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum0Cur7 < 0)
                            {
                                examAlum0Cur7 = 0;
                            }
                            else if (examAlum0Cur7 > 20)
                            {
                                examAlum0Cur7 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum0Cur7) * 0.8);

                            Alum0CursosPromfin[7] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[7] + " es: " + Alum0CursosPromfin[7]);
                            // PROMEDIO ES : Alum0CursosPromfin[7]
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                    }
                }


                // --------------DATOS ALUMNO [1] -------------------

                //CANTIDAD DE CURSOS DEL ALUMNO [1] 
                double[] curalum1 = new double[8];

                //LABORATORIOS(10) DE CADA CURSO 
                double[] labAlum1Cur0 = new double[10];
                double[] labAlum1Cur1 = new double[10];
                double[] labAlum1Cur2 = new double[10];
                double[] labAlum1Cur3 = new double[10];
                double[] labAlum1Cur4 = new double[10];
                double[] labAlum1Cur5 = new double[10];
                double[] labAlum1Cur6 = new double[10];
                double[] labAlum1Cur7 = new double[10];

                //Los promedios de los Cursos del alumno [1] : 
                double[] Alum1CursosPromfin = new double[8];


                // -------------------------------------------------------------SOLO ALUMNO [1]-- 
                Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("");
                Console.WriteLine($"---------------------DATOS DEL ESTUDIANTE 2--------------------");
                Console.WriteLine($"Nombre del estudiante 2: ");
                nom[1] = Console.ReadLine();
                Console.WriteLine("");

                //DECLARO INDEX 
                string value1 = nom[1];
                int index1 = Array.IndexOf(nom, value1);

                //PREGUNTO INDEX
                if (index1 == 1)
                {
                    //repite la cantidad de cursos (8)
                    for (double j = 0; j < curalum1.Length; j++)
                    {
                        //pregunta si el curso es 0
                        if (j == 0)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas de los laboratorios del curso de " + cur[0] + ": ");
                            double suma = 0;
                            //el curso 0 repetira los 10 laboratorios de ese curso ---CERO---
                            for (int a = 0; a < labAlum1Cur0.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum1Cur0[a] = double.Parse(Console.ReadLine());

                                //Validación de notas...
                                if (labAlum1Cur0[a] < 0)
                                {
                                    labAlum1Cur0[a] = 0;
                                }
                                else if (labAlum1Cur0[a] > 20)
                                {
                                    labAlum1Cur0[a] = 20;
                                }

                                suma += labAlum1Cur0[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[0] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum1Cur0 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum1Cur0 < 0)
                            {
                                examAlum1Cur0 = 0;
                            }
                            else if (examAlum1Cur0 > 20)
                            {
                                examAlum1Cur0 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum1Cur0) * 0.8);

                            Alum1CursosPromfin[0] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[0] + " es: " + Alum1CursosPromfin[0]);
                            // PROMEDIO ES : Alum1CursosPromfin[0]   
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 1
                        else if (j == 1)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[1] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 1 repetira los 10 laboratorios de ese curso ---UNO---
                            for (int a = 0; a < labAlum1Cur1.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum1Cur1[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum1Cur1[a] < 0)
                                {
                                    labAlum1Cur1[a] = 0;
                                }
                                else if (labAlum1Cur1[a] > 20)
                                {
                                    labAlum1Cur1[a] = 20;
                                }

                                suma += labAlum1Cur1[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[1] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum1Cur1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum1Cur1 < 0)
                            {
                                examAlum1Cur1 = 0;
                            }
                            else if (examAlum1Cur1 > 20)
                            {
                                examAlum1Cur1 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum1Cur1) * 0.8);

                            Alum1CursosPromfin[1] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[1] + " es: " + Alum1CursosPromfin[1]);
                            // PROMEDIO ES : Alum1CursosPromfin[1] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 2
                        else if (j == 2)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[2] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 2 repetira los 10 laboratorios de ese curso ---DOS---
                            for (int a = 0; a < labAlum1Cur2.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum1Cur2[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum1Cur2[a] < 0)
                                {
                                    labAlum1Cur2[a] = 0;
                                }
                                else if (labAlum1Cur2[a] > 20)
                                {
                                    labAlum1Cur2[a] = 20;
                                }

                                suma += labAlum1Cur2[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[2] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum1Cur2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum1Cur2 < 0)
                            {
                                examAlum1Cur2 = 0;
                            }
                            else if (examAlum1Cur2 > 20)
                            {
                                examAlum1Cur2 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum1Cur2) * 0.8);

                            Alum1CursosPromfin[2] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[2] + " es: " + Alum1CursosPromfin[2]);
                            // PROMEDIO ES : Alum1CursosPromfin[2] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 3
                        else if (j == 3)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[3] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 3 repetira los 10 laboratorios de ese curso ---TRES---
                            for (int a = 0; a < labAlum1Cur3.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum1Cur3[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum1Cur3[a] < 0)
                                {
                                    labAlum1Cur3[a] = 0;
                                }
                                else if (labAlum1Cur3[a] > 20)
                                {
                                    labAlum1Cur3[a] = 20;
                                }

                                suma += labAlum1Cur3[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[3] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum1Cur3 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum1Cur3 < 0)
                            {
                                examAlum1Cur3 = 0;
                            }
                            else if (examAlum1Cur3 > 20)
                            {
                                examAlum1Cur3 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum1Cur3) * 0.8);

                            Alum1CursosPromfin[3] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[3] + " es: " + Alum1CursosPromfin[3]);
                            // PROMEDIO ES : Alum1CursosPromfin[3] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 4
                        else if (j == 4)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[4] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 4 repetira los 10 laboratorios de ese curso ---CUATRO---
                            for (int a = 0; a < labAlum1Cur4.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum1Cur4[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum1Cur4[a] < 0)
                                {
                                    labAlum1Cur4[a] = 0;
                                }
                                else if (labAlum1Cur4[a] > 20)
                                {
                                    labAlum1Cur4[a] = 20;
                                }

                                suma += labAlum1Cur4[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[4] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum1Cur4 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum1Cur4 < 0)
                            {
                                examAlum1Cur4 = 0;
                            }
                            else if (examAlum1Cur4 > 20)
                            {
                                examAlum1Cur4 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum1Cur4) * 0.8);

                            Alum1CursosPromfin[4] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[4] + " es: " + Alum1CursosPromfin[4]);
                            // PROMEDIO ES : Alum1CursosPromfin[4] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 5
                        else if (j == 5)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[5] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 5 repetira los 10 laboratorios de ese curso ---CINCO---
                            for (int a = 0; a < labAlum1Cur5.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum1Cur5[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum1Cur5[a] < 0)
                                {
                                    labAlum1Cur5[a] = 0;
                                }
                                else if (labAlum1Cur5[a] > 20)
                                {
                                    labAlum1Cur5[a] = 20;
                                }

                                suma += labAlum1Cur5[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[5] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum1Cur5 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum1Cur5 < 0)
                            {
                                examAlum1Cur5 = 0;
                            }
                            else if (examAlum1Cur5 > 20)
                            {
                                examAlum1Cur5 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum1Cur5) * 0.8);

                            Alum1CursosPromfin[5] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[5] + " es: " + Alum1CursosPromfin[5]);
                            // PROMEDIO ES : Alum1CursosPromfin[5] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 6
                        else if (j == 6)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[6] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 6 repetira los 10 laboratorios de ese curso ---SEIS---
                            for (int a = 0; a < labAlum1Cur6.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum1Cur6[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum1Cur6[a] < 0)
                                {
                                    labAlum1Cur6[a] = 0;
                                }
                                else if (labAlum1Cur6[a] > 20)
                                {
                                    labAlum1Cur6[a] = 20;
                                }

                                suma += labAlum1Cur6[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[6] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum1Cur6 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum1Cur6 < 0)
                            {
                                examAlum1Cur6 = 0;
                            }
                            else if (examAlum1Cur6 > 20)
                            {
                                examAlum1Cur6 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum1Cur6) * 0.8);

                            Alum1CursosPromfin[6] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[6] + " es: " + Alum1CursosPromfin[6]);
                            // PROMEDIO ES : Alum1CursosPromfin[6] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 7
                        else if (j == 7)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[7] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 7 repetira los 10 laboratorios de ese curso ---SIETE---
                            for (int a = 0; a < labAlum1Cur7.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum1Cur7[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum1Cur7[a] < 0)
                                {
                                    labAlum1Cur7[a] = 0;
                                }
                                else if (labAlum1Cur7[a] > 20)
                                {
                                    labAlum1Cur7[a] = 20;
                                }

                                suma += labAlum1Cur7[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[7] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum1Cur7 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum1Cur7 < 0)
                            {
                                examAlum1Cur7 = 0;
                            }
                            else if (examAlum1Cur7 > 20)
                            {
                                examAlum1Cur7 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum1Cur7) * 0.8);

                            Alum1CursosPromfin[7] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[7] + " es: " + Alum1CursosPromfin[7]);
                            // PROMEDIO ES : Alum1CursosPromfin[7]
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                    }
                }


                // --------------DATOS ALUMNO [2] -------------------

                //CANTIDAD DE CURSOS DEL ALUMNO [2] 
                double[] curalum2 = new double[8];

                //LABORATORIOS(10) DE CADA CURSO 
                double[] labAlum2Cur0 = new double[10];
                double[] labAlum2Cur1 = new double[10];
                double[] labAlum2Cur2 = new double[10];
                double[] labAlum2Cur3 = new double[10];
                double[] labAlum2Cur4 = new double[10];
                double[] labAlum2Cur5 = new double[10];
                double[] labAlum2Cur6 = new double[10];
                double[] labAlum2Cur7 = new double[10];

                //Los promedios de los Cursos del alumno [2] : 
                double[] Alum2CursosPromfin = new double[8];


                // -------------------------------------------------------------SOLO ALUMNO [2]-- 
                Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("");
                Console.WriteLine($"---------------------DATOS DEL ESTUDIANTE 3--------------------");
                Console.WriteLine($"Nombre del estudiante 3: ");
                nom[2] = Console.ReadLine();
                Console.WriteLine("");

                //DECLARO INDEX 
                string value2 = nom[2];
                int index2 = Array.IndexOf(nom, value2);

                //PREGUNTO INDEX
                if (index2 == 2)
                {
                    //repite la cantidad de cursos (8)
                    for (double j = 0; j < curalum2.Length; j++)
                    {
                        //pregunta si el curso es 0
                        if (j == 0)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas de los laboratorios del curso de " + cur[0] + ": ");
                            double suma = 0;
                            //el curso 0 repetira los 10 laboratorios de ese curso ---CERO---
                            for (int a = 0; a < labAlum2Cur0.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum2Cur0[a] = double.Parse(Console.ReadLine());

                                //Validación de notas...
                                if (labAlum2Cur0[a] < 0)
                                {
                                    labAlum2Cur0[a] = 0;
                                }
                                else if (labAlum2Cur0[a] > 20)
                                {
                                    labAlum2Cur0[a] = 20;
                                }

                                suma += labAlum2Cur0[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[0] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum2Cur0 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum2Cur0 < 0)
                            {
                                examAlum2Cur0 = 0;
                            }
                            else if (examAlum2Cur0 > 20)
                            {
                                examAlum2Cur0 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum2Cur0) * 0.8);

                            Alum2CursosPromfin[0] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[0] + " es: " + Alum2CursosPromfin[0]);
                            // PROMEDIO ES : Alum2CursosPromfin[0]   
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 1
                        else if (j == 1)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[1] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 1 repetira los 10 laboratorios de ese curso ---UNO---
                            for (int a = 0; a < labAlum2Cur1.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum2Cur1[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum2Cur1[a] < 0)
                                {
                                    labAlum2Cur1[a] = 0;
                                }
                                else if (labAlum2Cur1[a] > 20)
                                {
                                    labAlum2Cur1[a] = 20;
                                }

                                suma += labAlum2Cur1[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[1] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum2Cur1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum2Cur1 < 0)
                            {
                                examAlum2Cur1 = 0;
                            }
                            else if (examAlum2Cur1 > 20)
                            {
                                examAlum2Cur1 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum2Cur1) * 0.8);

                            Alum2CursosPromfin[1] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[1] + " es: " + Alum2CursosPromfin[1]);
                            // PROMEDIO ES : Alum2CursosPromfin[1] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 2
                        else if (j == 2)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[2] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 2 repetira los 10 laboratorios de ese curso ---DOS---
                            for (int a = 0; a < labAlum2Cur2.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum2Cur2[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum2Cur2[a] < 0)
                                {
                                    labAlum2Cur2[a] = 0;
                                }
                                else if (labAlum2Cur2[a] > 20)
                                {
                                    labAlum2Cur2[a] = 20;
                                }

                                suma += labAlum2Cur2[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[2] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum2Cur2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum2Cur2 < 0)
                            {
                                examAlum2Cur2 = 0;
                            }
                            else if (examAlum2Cur2 > 20)
                            {
                                examAlum2Cur2 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum2Cur2) * 0.8);

                            Alum2CursosPromfin[2] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[2] + " es: " + Alum2CursosPromfin[2]);
                            // PROMEDIO ES : Alum2CursosPromfin[2] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 3
                        else if (j == 3)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[3] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 3 repetira los 10 laboratorios de ese curso ---TRES---
                            for (int a = 0; a < labAlum2Cur3.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum2Cur3[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum2Cur3[a] < 0)
                                {
                                    labAlum2Cur3[a] = 0;
                                }
                                else if (labAlum2Cur3[a] > 20)
                                {
                                    labAlum2Cur3[a] = 20;
                                }

                                suma += labAlum2Cur3[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[3] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum2Cur3 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum2Cur3 < 0)
                            {
                                examAlum2Cur3 = 0;
                            }
                            else if (examAlum2Cur3 > 20)
                            {
                                examAlum2Cur3 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum2Cur3) * 0.8);

                            Alum2CursosPromfin[3] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[3] + " es: " + Alum2CursosPromfin[3]);
                            // PROMEDIO ES : Alum2CursosPromfin[3] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 4
                        else if (j == 4)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[4] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 4 repetira los 10 laboratorios de ese curso ---CUATRO---
                            for (int a = 0; a < labAlum2Cur4.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum2Cur4[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum2Cur4[a] < 0)
                                {
                                    labAlum2Cur4[a] = 0;
                                }
                                else if (labAlum2Cur4[a] > 20)
                                {
                                    labAlum2Cur4[a] = 20;
                                }

                                suma += labAlum2Cur4[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[4] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum2Cur4 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum2Cur4 < 0)
                            {
                                examAlum2Cur4 = 0;
                            }
                            else if (examAlum2Cur4 > 20)
                            {
                                examAlum2Cur4 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum2Cur4) * 0.8);

                            Alum2CursosPromfin[4] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[4] + " es: " + Alum2CursosPromfin[4]);
                            // PROMEDIO ES : Alum2CursosPromfin[4] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 5
                        else if (j == 5)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[5] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 5 repetira los 10 laboratorios de ese curso ---CINCO---
                            for (int a = 0; a < labAlum2Cur5.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum2Cur5[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum2Cur5[a] < 0)
                                {
                                    labAlum2Cur5[a] = 0;
                                }
                                else if (labAlum2Cur5[a] > 20)
                                {
                                    labAlum2Cur5[a] = 20;
                                }

                                suma += labAlum2Cur5[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[5] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum2Cur5 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum2Cur5 < 0)
                            {
                                examAlum2Cur5 = 0;
                            }
                            else if (examAlum2Cur5 > 20)
                            {
                                examAlum2Cur5 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum2Cur5) * 0.8);

                            Alum2CursosPromfin[5] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[5] + " es: " + Alum2CursosPromfin[5]);
                            // PROMEDIO ES : Alum2CursosPromfin[5] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 6
                        else if (j == 6)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[6] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 6 repetira los 10 laboratorios de ese curso ---SEIS---
                            for (int a = 0; a < labAlum2Cur6.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum2Cur6[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum2Cur6[a] < 0)
                                {
                                    labAlum2Cur6[a] = 0;
                                }
                                else if (labAlum2Cur6[a] > 20)
                                {
                                    labAlum2Cur6[a] = 20;
                                }

                                suma += labAlum2Cur6[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[6] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum2Cur6 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum2Cur6 < 0)
                            {
                                examAlum2Cur6 = 0;
                            }
                            else if (examAlum2Cur6 > 20)
                            {
                                examAlum2Cur6 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum2Cur6) * 0.8);

                            Alum2CursosPromfin[6] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[6] + " es: " + Alum2CursosPromfin[6]);
                            // PROMEDIO ES : Alum2CursosPromfin[6] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 7
                        else if (j == 7)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[7] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 7 repetira los 10 laboratorios de ese curso ---SIETE---
                            for (int a = 0; a < labAlum2Cur7.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum2Cur7[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum2Cur7[a] < 0)
                                {
                                    labAlum2Cur7[a] = 0;
                                }
                                else if (labAlum2Cur7[a] > 20)
                                {
                                    labAlum2Cur7[a] = 20;
                                }

                                suma += labAlum2Cur7[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[7] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum2Cur7 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum2Cur7 < 0)
                            {
                                examAlum2Cur7 = 0;
                            }
                            else if (examAlum2Cur7 > 20)
                            {
                                examAlum2Cur7 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum2Cur7) * 0.8);

                            Alum2CursosPromfin[7] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[7] + " es: " + Alum2CursosPromfin[7]);
                            // PROMEDIO ES : Alum2CursosPromfin[7]
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                    }
                }


                // --------------DATOS ALUMNO [3] -------------------

                //CANTIDAD DE CURSOS DEL ALUMNO [3] 
                double[] curalum3 = new double[8];

                //LABORATORIOS(10) DE CADA CURSO 
                double[] labAlum3Cur0 = new double[10];
                double[] labAlum3Cur1 = new double[10];
                double[] labAlum3Cur2 = new double[10];
                double[] labAlum3Cur3 = new double[10];
                double[] labAlum3Cur4 = new double[10];
                double[] labAlum3Cur5 = new double[10];
                double[] labAlum3Cur6 = new double[10];
                double[] labAlum3Cur7 = new double[10];

                //Los promedios de los Cursos del alumno [3] : 
                double[] Alum3CursosPromfin = new double[8];


                // -------------------------------------------------------------SOLO ALUMNO [3]-- 
                Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("");
                Console.WriteLine($"---------------------DATOS DEL ESTUDIANTE 4--------------------");
                Console.WriteLine($"Nombre del estudiante 4: ");
                nom[3] = Console.ReadLine();
                Console.WriteLine("");

                //DECLARO INDEX 
                string value3 = nom[3];
                int index3 = Array.IndexOf(nom, value3);

                //PREGUNTO INDEX
                if (index3 == 3)
                {
                    //repite la cantidad de cursos (8)
                    for (double j = 0; j < curalum3.Length; j++)
                    {
                        //pregunta si el curso es 0
                        if (j == 0)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas de los laboratorios del curso de " + cur[0] + ": ");
                            double suma = 0;
                            //el curso 0 repetira los 10 laboratorios de ese curso ---CERO---
                            for (int a = 0; a < labAlum3Cur0.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum3Cur0[a] = double.Parse(Console.ReadLine());

                                //Validación de notas...
                                if (labAlum3Cur0[a] < 0)
                                {
                                    labAlum3Cur0[a] = 0;
                                }
                                else if (labAlum3Cur0[a] > 20)
                                {
                                    labAlum3Cur0[a] = 20;
                                }

                                suma += labAlum3Cur0[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[0] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum3Cur0 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum3Cur0 < 0)
                            {
                                examAlum3Cur0 = 0;
                            }
                            else if (examAlum3Cur0 > 20)
                            {
                                examAlum3Cur0 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum3Cur0) * 0.8);

                            Alum3CursosPromfin[0] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[0] + " es: " + Alum3CursosPromfin[0]);
                            // PROMEDIO ES : Alum3CursosPromfin[0]   
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 1
                        else if (j == 1)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[1] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 1 repetira los 10 laboratorios de ese curso ---UNO---
                            for (int a = 0; a < labAlum3Cur1.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum3Cur1[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum3Cur1[a] < 0)
                                {
                                    labAlum3Cur1[a] = 0;
                                }
                                else if (labAlum3Cur1[a] > 20)
                                {
                                    labAlum3Cur1[a] = 20;
                                }

                                suma += labAlum3Cur1[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[1] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum3Cur1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum3Cur1 < 0)
                            {
                                examAlum3Cur1 = 0;
                            }
                            else if (examAlum3Cur1 > 20)
                            {
                                examAlum3Cur1 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum3Cur1) * 0.8);

                            Alum3CursosPromfin[1] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[1] + " es: " + Alum3CursosPromfin[1]);
                            // PROMEDIO ES : Alum3CursosPromfin[1] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 2
                        else if (j == 2)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[2] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 2 repetira los 10 laboratorios de ese curso ---DOS---
                            for (int a = 0; a < labAlum3Cur2.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum3Cur2[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum3Cur2[a] < 0)
                                {
                                    labAlum3Cur2[a] = 0;
                                }
                                else if (labAlum3Cur2[a] > 20)
                                {
                                    labAlum3Cur2[a] = 20;
                                }

                                suma += labAlum3Cur2[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[2] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum3Cur2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum3Cur2 < 0)
                            {
                                examAlum3Cur2 = 0;
                            }
                            else if (examAlum3Cur2 > 20)
                            {
                                examAlum3Cur2 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum3Cur2) * 0.8);

                            Alum3CursosPromfin[2] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[2] + " es: " + Alum3CursosPromfin[2]);
                            // PROMEDIO ES : Alum3CursosPromfin[2] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 3
                        else if (j == 3)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[3] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 3 repetira los 10 laboratorios de ese curso ---TRES---
                            for (int a = 0; a < labAlum3Cur3.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum3Cur3[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum3Cur3[a] < 0)
                                {
                                    labAlum3Cur3[a] = 0;
                                }
                                else if (labAlum3Cur3[a] > 20)
                                {
                                    labAlum3Cur3[a] = 20;
                                }

                                suma += labAlum3Cur3[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[3] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum3Cur3 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum3Cur3 < 0)
                            {
                                examAlum3Cur3 = 0;
                            }
                            else if (examAlum3Cur3 > 20)
                            {
                                examAlum3Cur3 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum3Cur3) * 0.8);

                            Alum3CursosPromfin[3] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[3] + " es: " + Alum3CursosPromfin[3]);
                            // PROMEDIO ES : Alum3CursosPromfin[3] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 4
                        else if (j == 4)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[4] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 4 repetira los 10 laboratorios de ese curso ---CUATRO---
                            for (int a = 0; a < labAlum3Cur4.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum3Cur4[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum3Cur4[a] < 0)
                                {
                                    labAlum3Cur4[a] = 0;
                                }
                                else if (labAlum3Cur4[a] > 20)
                                {
                                    labAlum3Cur4[a] = 20;
                                }

                                suma += labAlum3Cur4[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[4] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum3Cur4 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum3Cur4 < 0)
                            {
                                examAlum3Cur4 = 0;
                            }
                            else if (examAlum3Cur4 > 20)
                            {
                                examAlum3Cur4 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum3Cur4) * 0.8);

                            Alum3CursosPromfin[4] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[4] + " es: " + Alum3CursosPromfin[4]);
                            // PROMEDIO ES : Alum3CursosPromfin[4] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 5
                        else if (j == 5)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[5] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 5 repetira los 10 laboratorios de ese curso ---CINCO---
                            for (int a = 0; a < labAlum3Cur5.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum3Cur5[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum3Cur5[a] < 0)
                                {
                                    labAlum3Cur5[a] = 0;
                                }
                                else if (labAlum3Cur5[a] > 20)
                                {
                                    labAlum3Cur5[a] = 20;
                                }

                                suma += labAlum3Cur5[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[5] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum3Cur5 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum3Cur5 < 0)
                            {
                                examAlum3Cur5 = 0;
                            }
                            else if (examAlum3Cur5 > 20)
                            {
                                examAlum3Cur5 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum3Cur5) * 0.8);

                            Alum3CursosPromfin[5] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[5] + " es: " + Alum3CursosPromfin[5]);
                            // PROMEDIO ES : Alum3CursosPromfin[5] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 6
                        else if (j == 6)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[6] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 6 repetira los 10 laboratorios de ese curso ---SEIS---
                            for (int a = 0; a < labAlum3Cur6.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum3Cur6[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum3Cur6[a] < 0)
                                {
                                    labAlum3Cur6[a] = 0;
                                }
                                else if (labAlum3Cur6[a] > 20)
                                {
                                    labAlum3Cur6[a] = 20;
                                }

                                suma += labAlum3Cur6[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[6] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum3Cur6 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum3Cur6 < 0)
                            {
                                examAlum3Cur6 = 0;
                            }
                            else if (examAlum3Cur6 > 20)
                            {
                                examAlum3Cur6 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum3Cur6) * 0.8);

                            Alum3CursosPromfin[6] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[6] + " es: " + Alum3CursosPromfin[6]);
                            // PROMEDIO ES : Alum3CursosPromfin[6] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 7
                        else if (j == 7)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[7] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 7 repetira los 10 laboratorios de ese curso ---SIETE---
                            for (int a = 0; a < labAlum3Cur7.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum3Cur7[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum3Cur7[a] < 0)
                                {
                                    labAlum3Cur7[a] = 0;
                                }
                                else if (labAlum3Cur7[a] > 20)
                                {
                                    labAlum3Cur7[a] = 20;
                                }

                                suma += labAlum3Cur7[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[7] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum3Cur7 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum3Cur7 < 0)
                            {
                                examAlum3Cur7 = 0;
                            }
                            else if (examAlum3Cur7 > 20)
                            {
                                examAlum3Cur7 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum3Cur7) * 0.8);

                            Alum3CursosPromfin[7] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[7] + " es: " + Alum3CursosPromfin[7]);
                            // PROMEDIO ES : Alum3CursosPromfin[7]
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                    }
                }


                // --------------DATOS ALUMNO [4] -------------------

                //CANTIDAD DE CURSOS DEL ALUMNO [4] 
                double[] curalum4 = new double[8];

                //LABORATORIOS(10) DE CADA CURSO 
                double[] labAlum4Cur0 = new double[10];
                double[] labAlum4Cur1 = new double[10];
                double[] labAlum4Cur2 = new double[10];
                double[] labAlum4Cur3 = new double[10];
                double[] labAlum4Cur4 = new double[10];
                double[] labAlum4Cur5 = new double[10];
                double[] labAlum4Cur6 = new double[10];
                double[] labAlum4Cur7 = new double[10];

                //Los promedios de los Cursos del alumno [4] : 
                double[] Alum4CursosPromfin = new double[8];


                // -------------------------------------------------------------SOLO ALUMNO [4]-- 
                Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("");
                Console.WriteLine($"---------------------DATOS DEL ESTUDIANTE 5--------------------");
                Console.WriteLine($"Nombre del estudiante 5: ");
                nom[4] = Console.ReadLine();
                Console.WriteLine("");

                //DECLARO INDEX 
                string value4 = nom[4];
                int index4 = Array.IndexOf(nom, value4);

                //PREGUNTO INDEX
                if (index4 == 4)
                {
                    //repite la cantidad de cursos (8)
                    for (double j = 0; j < curalum4.Length; j++)
                    {
                        //pregunta si el curso es 0
                        if (j == 0)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas de los laboratorios del curso de " + cur[0] + ": ");
                            double suma = 0;
                            //el curso 0 repetira los 10 laboratorios de ese curso ---CERO---
                            for (int a = 0; a < labAlum4Cur0.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum4Cur0[a] = double.Parse(Console.ReadLine());

                                //Validación de notas...
                                if (labAlum4Cur0[a] < 0)
                                {
                                    labAlum4Cur0[a] = 0;
                                }
                                else if (labAlum4Cur0[a] > 20)
                                {
                                    labAlum4Cur0[a] = 20;
                                }

                                suma += labAlum4Cur0[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[0] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum4Cur0 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum4Cur0 < 0)
                            {
                                examAlum4Cur0 = 0;
                            }
                            else if (examAlum4Cur0 > 20)
                            {
                                examAlum4Cur0 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum4Cur0) * 0.8);

                            Alum4CursosPromfin[0] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[0] + " es: " + Alum4CursosPromfin[0]);
                            // PROMEDIO ES : Alum4CursosPromfin[0]   
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 1
                        else if (j == 1)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[1] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 1 repetira los 10 laboratorios de ese curso ---UNO---
                            for (int a = 0; a < labAlum4Cur1.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum4Cur1[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum4Cur1[a] < 0)
                                {
                                    labAlum4Cur1[a] = 0;
                                }
                                else if (labAlum4Cur1[a] > 20)
                                {
                                    labAlum4Cur1[a] = 20;
                                }

                                suma += labAlum4Cur1[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[1] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum4Cur1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum4Cur1 < 0)
                            {
                                examAlum4Cur1 = 0;
                            }
                            else if (examAlum4Cur1 > 20)
                            {
                                examAlum4Cur1 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum4Cur1) * 0.8);

                            Alum4CursosPromfin[1] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[1] + " es: " + Alum4CursosPromfin[1]);
                            // PROMEDIO ES : Alum4CursosPromfin[1] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 2
                        else if (j == 2)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[2] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 2 repetira los 10 laboratorios de ese curso ---DOS---
                            for (int a = 0; a < labAlum4Cur2.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum4Cur2[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum4Cur2[a] < 0)
                                {
                                    labAlum4Cur2[a] = 0;
                                }
                                else if (labAlum4Cur2[a] > 20)
                                {
                                    labAlum4Cur2[a] = 20;
                                }

                                suma += labAlum4Cur2[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[2] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum4Cur2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum4Cur2 < 0)
                            {
                                examAlum4Cur2 = 0;
                            }
                            else if (examAlum4Cur2 > 20)
                            {
                                examAlum4Cur2 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum4Cur2) * 0.8);

                            Alum4CursosPromfin[2] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[2] + " es: " + Alum4CursosPromfin[2]);
                            // PROMEDIO ES : Alum4CursosPromfin[2] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 3
                        else if (j == 3)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[3] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 3 repetira los 10 laboratorios de ese curso ---TRES---
                            for (int a = 0; a < labAlum4Cur3.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum4Cur3[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum4Cur3[a] < 0)
                                {
                                    labAlum4Cur3[a] = 0;
                                }
                                else if (labAlum4Cur3[a] > 20)
                                {
                                    labAlum4Cur3[a] = 20;
                                }

                                suma += labAlum4Cur3[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[3] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum4Cur3 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum4Cur3 < 0)
                            {
                                examAlum4Cur3 = 0;
                            }
                            else if (examAlum4Cur3 > 20)
                            {
                                examAlum4Cur3 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum4Cur3) * 0.8);

                            Alum4CursosPromfin[3] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[3] + " es: " + Alum4CursosPromfin[3]);
                            // PROMEDIO ES : Alum4CursosPromfin[3] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 4
                        else if (j == 4)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[4] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 4 repetira los 10 laboratorios de ese curso ---CUATRO---
                            for (int a = 0; a < labAlum4Cur4.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum4Cur4[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum4Cur4[a] < 0)
                                {
                                    labAlum4Cur4[a] = 0;
                                }
                                else if (labAlum4Cur4[a] > 20)
                                {
                                    labAlum4Cur4[a] = 20;
                                }

                                suma += labAlum4Cur4[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[4] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum4Cur4 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum4Cur4 < 0)
                            {
                                examAlum4Cur4 = 0;
                            }
                            else if (examAlum4Cur4 > 20)
                            {
                                examAlum4Cur4 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum4Cur4) * 0.8);

                            Alum4CursosPromfin[4] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[4] + " es: " + Alum4CursosPromfin[4]);
                            // PROMEDIO ES : Alum4CursosPromfin[4] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 5
                        else if (j == 5)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[5] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 5 repetira los 10 laboratorios de ese curso ---CINCO---
                            for (int a = 0; a < labAlum4Cur5.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum4Cur5[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum4Cur5[a] < 0)
                                {
                                    labAlum4Cur5[a] = 0;
                                }
                                else if (labAlum4Cur5[a] > 20)
                                {
                                    labAlum4Cur5[a] = 20;
                                }

                                suma += labAlum4Cur5[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[5] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum4Cur5 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum4Cur5 < 0)
                            {
                                examAlum4Cur5 = 0;
                            }
                            else if (examAlum4Cur5 > 20)
                            {
                                examAlum4Cur5 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum4Cur5) * 0.8);

                            Alum4CursosPromfin[5] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[5] + " es: " + Alum4CursosPromfin[5]);
                            // PROMEDIO ES : Alum4CursosPromfin[5] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 6
                        else if (j == 6)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[6] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 6 repetira los 10 laboratorios de ese curso ---SEIS---
                            for (int a = 0; a < labAlum4Cur6.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum4Cur6[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum4Cur6[a] < 0)
                                {
                                    labAlum4Cur6[a] = 0;
                                }
                                else if (labAlum4Cur6[a] > 20)
                                {
                                    labAlum4Cur6[a] = 20;
                                }

                                suma += labAlum4Cur6[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[6] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum4Cur6 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum4Cur6 < 0)
                            {
                                examAlum4Cur6 = 0;
                            }
                            else if (examAlum4Cur6 > 20)
                            {
                                examAlum4Cur6 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum4Cur6) * 0.8);

                            Alum4CursosPromfin[6] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[6] + " es: " + Alum4CursosPromfin[6]);
                            // PROMEDIO ES : Alum4CursosPromfin[6] 
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        //pregunta si el curso es 7
                        else if (j == 7)
                        {
                            Console.WriteLine($"---------------------CURSO {j + 1}--------------------");
                            Console.WriteLine("Ingrese 10 notas del laboratorios del curso de " + cur[7] + ": ");
                            double suma = 0;
                            //si se cumple que el curso es 7 repetira los 10 laboratorios de ese curso ---SIETE---
                            for (int a = 0; a < labAlum4Cur7.Length; a++)
                            {
                                Console.WriteLine($"Nota {a + 1} :");
                                labAlum4Cur7[a] = double.Parse(Console.ReadLine());

                                //Validación de los laboratorios...
                                if (labAlum4Cur7[a] < 0)
                                {
                                    labAlum4Cur7[a] = 0;
                                }
                                else if (labAlum4Cur7[a] > 20)
                                {
                                    labAlum4Cur7[a] = 20;
                                }

                                suma += labAlum4Cur7[a];
                            }

                            Console.WriteLine("----------------------EXAMEN FINAL DE " + cur[7] + "--------------------");
                            Console.WriteLine("Ingrese puntuación del examen: ");
                            double examAlum4Cur7 = double.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            //Validación del examen...
                            if (examAlum4Cur7 < 0)
                            {
                                examAlum4Cur7 = 0;
                            }
                            else if (examAlum4Cur7 > 20)
                            {
                                examAlum4Cur7 = 20;
                            }

                            double prom = ((suma / 10) * 0.2) + ((examAlum4Cur7) * 0.8);

                            Alum4CursosPromfin[7] = prom;

                            Console.WriteLine("El promedio del curso de " + cur[7] + " es: " + Alum4CursosPromfin[7]);
                            // PROMEDIO ES : Alum4CursosPromfin[7]
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                    }
                }




                //-------------------------------------------------------------------------------------------------------------------------------------------------------
                //TÍTULO DEL PROYECTO Y RESULTADO
                Console.SetCursorPosition(15, 1296); Console.ForegroundColor = ConsoleColor.Green; Console.Write("LÓGICA DE PROGRAMACIÓN - CICLO III");
                Console.SetCursorPosition(15, 1298); Console.ForegroundColor = ConsoleColor.Green; Console.Write("PROYECTO FINAL");
                Console.SetCursorPosition(15, 1300); Console.ForegroundColor = ConsoleColor.Green; Console.Write("Alumno: Freddy H. Bastidas L.");
                Console.SetCursorPosition(15, 1302); Console.ForegroundColor = ConsoleColor.Green; Console.Write("Docente: José E. Vega E.");

                //TABLA 1
                Console.SetCursorPosition(0, 1304); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("-----------------------------------------------------------------------------------------------");

                Console.SetCursorPosition(1, 1305); Console.ForegroundColor = ConsoleColor.Green; Console.Write("DOCENTE");
                Console.SetCursorPosition(40, 1305); Console.ForegroundColor = ConsoleColor.Green; Console.Write("UNIDAD DIDÁCTICA");
                Console.SetCursorPosition(86, 1305); Console.ForegroundColor = ConsoleColor.Green; Console.Write("PROMEDIO");


                Console.SetCursorPosition(0, 1306); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("-----------------------------------------------------------------------------------------------");

                //DOCENTE
                Console.SetCursorPosition(1, 1307); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[0]);
                Console.SetCursorPosition(1, 1308); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[1]);
                Console.SetCursorPosition(1, 1309); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[2]);
                Console.SetCursorPosition(1, 1310); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[3]);
                Console.SetCursorPosition(1, 1311); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[4]);
                Console.SetCursorPosition(1, 1312); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[5]);
                Console.SetCursorPosition(1, 1313); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[6]);
                Console.SetCursorPosition(1, 1314); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[7]);

                //CURSO
                Console.SetCursorPosition(40, 1307); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[0]);
                Console.SetCursorPosition(40, 1308); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[1]);
                Console.SetCursorPosition(40, 1309); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[2]);
                Console.SetCursorPosition(40, 1310); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[3]);
                Console.SetCursorPosition(40, 1311); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[4]);
                Console.SetCursorPosition(40, 1312); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[5]);
                Console.SetCursorPosition(40, 1313); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[6]);
                Console.SetCursorPosition(40, 1314); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[7]);

                //PROMEDIO
                Console.SetCursorPosition(86, 1307); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum0CursosPromfin[0]);
                Console.SetCursorPosition(86, 1308); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum0CursosPromfin[1]);
                Console.SetCursorPosition(86, 1309); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum0CursosPromfin[2]);
                Console.SetCursorPosition(86, 1310); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum0CursosPromfin[3]);
                Console.SetCursorPosition(86, 1311); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum0CursosPromfin[4]);
                Console.SetCursorPosition(86, 1312); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum0CursosPromfin[5]);
                Console.SetCursorPosition(86, 1313); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum0CursosPromfin[6]);
                Console.SetCursorPosition(86, 1314); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum0CursosPromfin[7]);

                //ALUMNO
                Console.SetCursorPosition(1, 1316); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("ALUMNO: ");
                Console.SetCursorPosition(10, 1316); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(nom[0]);


                //PROMEDIO GENERAL
                double promGen0, sum0 = 0;
                sum0 += (Alum0CursosPromfin[0] + Alum0CursosPromfin[1] + Alum0CursosPromfin[2] + Alum0CursosPromfin[3] + Alum0CursosPromfin[4] + Alum0CursosPromfin[5] + Alum0CursosPromfin[6] + Alum0CursosPromfin[7]);
                promGen0 = sum0 / Alum0CursosPromfin.Length;

                Console.SetCursorPosition(1, 1318); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("PROMEDIO GENERAL: ");
                Console.SetCursorPosition(19, 1318); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write(promGen0);


                //-------------------------------------------------------------------------------------------------------------------------------------------------------
                //TABLA 2
                Console.SetCursorPosition(0, 1320); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("-----------------------------------------------------------------------------------------------");

                Console.SetCursorPosition(1, 1321); Console.ForegroundColor = ConsoleColor.Green; Console.Write("DOCENTE");
                Console.SetCursorPosition(40, 1321); Console.ForegroundColor = ConsoleColor.Green; Console.Write("UNIDAD DIDÁCTICA");
                Console.SetCursorPosition(86, 1321); Console.ForegroundColor = ConsoleColor.Green; Console.Write("PROMEDIO");


                Console.SetCursorPosition(0, 1322); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("-----------------------------------------------------------------------------------------------");

                //DOCENTE
                Console.SetCursorPosition(1, 1323); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[0]);
                Console.SetCursorPosition(1, 1324); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[1]);
                Console.SetCursorPosition(1, 1325); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[2]);
                Console.SetCursorPosition(1, 1326); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[3]);
                Console.SetCursorPosition(1, 1327); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[4]);
                Console.SetCursorPosition(1, 1328); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[5]);
                Console.SetCursorPosition(1, 1329); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[6]);
                Console.SetCursorPosition(1, 1330); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[7]);

                //CURSO
                Console.SetCursorPosition(40, 1323); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[0]);
                Console.SetCursorPosition(40, 1324); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[1]);
                Console.SetCursorPosition(40, 1325); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[2]);
                Console.SetCursorPosition(40, 1326); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[3]);
                Console.SetCursorPosition(40, 1327); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[4]);
                Console.SetCursorPosition(40, 1328); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[5]);
                Console.SetCursorPosition(40, 1329); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[6]);
                Console.SetCursorPosition(40, 1330); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[7]);

                //PROMEDIO
                Console.SetCursorPosition(86, 1323); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum1CursosPromfin[0]);
                Console.SetCursorPosition(86, 1324); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum1CursosPromfin[1]);
                Console.SetCursorPosition(86, 1325); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum1CursosPromfin[2]);
                Console.SetCursorPosition(86, 1326); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum1CursosPromfin[3]);
                Console.SetCursorPosition(86, 1327); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum1CursosPromfin[4]);
                Console.SetCursorPosition(86, 1328); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum1CursosPromfin[5]);
                Console.SetCursorPosition(86, 1329); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum1CursosPromfin[6]);
                Console.SetCursorPosition(86, 1330); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum1CursosPromfin[7]);

                //ALUMNO
                Console.SetCursorPosition(1, 1332); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("ALUMNO: ");
                Console.SetCursorPosition(10, 1332); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(nom[1]);


                //PROMEDIO GENERAL
                double promGen1, sum1 = 0;
                sum1 += (Alum1CursosPromfin[0] + Alum1CursosPromfin[1] + Alum1CursosPromfin[2] + Alum1CursosPromfin[3] + Alum1CursosPromfin[4] + Alum1CursosPromfin[5] + Alum1CursosPromfin[6] + Alum1CursosPromfin[7]);
                promGen1 = sum1 / Alum1CursosPromfin.Length;

                Console.SetCursorPosition(1, 1334); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("PROMEDIO GENERAL: ");
                Console.SetCursorPosition(19, 1334); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write(promGen1);


                
                //-------------------------------------------------------------------------------------------------------------------------------------------------------
                //TABLA 3
                Console.SetCursorPosition(0, 1336); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("-----------------------------------------------------------------------------------------------");

                Console.SetCursorPosition(1, 1337); Console.ForegroundColor = ConsoleColor.Green; Console.Write("DOCENTE");
                Console.SetCursorPosition(40, 1337); Console.ForegroundColor = ConsoleColor.Green; Console.Write("UNIDAD DIDÁCTICA");
                Console.SetCursorPosition(86, 1337); Console.ForegroundColor = ConsoleColor.Green; Console.Write("PROMEDIO");


                Console.SetCursorPosition(0, 1338); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("-----------------------------------------------------------------------------------------------");

                //DOCENTE
                Console.SetCursorPosition(1, 1339); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[0]);
                Console.SetCursorPosition(1, 1340); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[1]);
                Console.SetCursorPosition(1, 1341); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[2]);
                Console.SetCursorPosition(1, 1342); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[3]);
                Console.SetCursorPosition(1, 1343); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[4]);
                Console.SetCursorPosition(1, 1344); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[5]);
                Console.SetCursorPosition(1, 1345); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[6]);
                Console.SetCursorPosition(1, 1346); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[7]);

                //CURSO
                Console.SetCursorPosition(40, 1339); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[0]);
                Console.SetCursorPosition(40, 1340); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[1]);
                Console.SetCursorPosition(40, 1341); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[2]);
                Console.SetCursorPosition(40, 1342); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[3]);
                Console.SetCursorPosition(40, 1343); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[4]);
                Console.SetCursorPosition(40, 1344); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[5]);
                Console.SetCursorPosition(40, 1345); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[6]);
                Console.SetCursorPosition(40, 1346); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[7]);

                //PROMEDIO
                Console.SetCursorPosition(86, 1339); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum2CursosPromfin[0]);
                Console.SetCursorPosition(86, 1340); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum2CursosPromfin[1]);
                Console.SetCursorPosition(86, 1341); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum2CursosPromfin[2]);
                Console.SetCursorPosition(86, 1342); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum2CursosPromfin[3]);
                Console.SetCursorPosition(86, 1343); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum2CursosPromfin[4]);
                Console.SetCursorPosition(86, 1344); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum2CursosPromfin[5]);
                Console.SetCursorPosition(86, 1345); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum2CursosPromfin[6]);
                Console.SetCursorPosition(86, 1346); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum2CursosPromfin[7]);

                //ALUMNO
                Console.SetCursorPosition(1, 1348); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("ALUMNO: ");
                Console.SetCursorPosition(10, 1348); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(nom[2]);


                //PROMEDIO GENERAL
                double promGen2, sum2 = 0;
                sum2 += (Alum2CursosPromfin[0] + Alum2CursosPromfin[1] + Alum2CursosPromfin[2] + Alum2CursosPromfin[3] + Alum2CursosPromfin[4] + Alum2CursosPromfin[5] + Alum2CursosPromfin[6] + Alum2CursosPromfin[7]);
                promGen2 = sum2 / Alum2CursosPromfin.Length;

                Console.SetCursorPosition(1, 1350); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("PROMEDIO GENERAL: ");
                Console.SetCursorPosition(19, 1350); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write(promGen2);


                //-------------------------------------------------------------------------------------------------------------------------------------------------------
                //TABLA 4
                Console.SetCursorPosition(0, 1352); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("-----------------------------------------------------------------------------------------------");

                Console.SetCursorPosition(1, 1353); Console.ForegroundColor = ConsoleColor.Green; Console.Write("DOCENTE");
                Console.SetCursorPosition(40, 1353); Console.ForegroundColor = ConsoleColor.Green; Console.Write("UNIDAD DIDÁCTICA");
                Console.SetCursorPosition(86, 1353); Console.ForegroundColor = ConsoleColor.Green; Console.Write("PROMEDIO");


                Console.SetCursorPosition(0, 1354); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("-----------------------------------------------------------------------------------------------");

                //DOCENTE
                Console.SetCursorPosition(1, 1355); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[0]);
                Console.SetCursorPosition(1, 1356); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[1]);
                Console.SetCursorPosition(1, 1357); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[2]);
                Console.SetCursorPosition(1, 1358); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[3]);
                Console.SetCursorPosition(1, 1359); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[4]);
                Console.SetCursorPosition(1, 1360); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[5]);
                Console.SetCursorPosition(1, 1361); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[6]);
                Console.SetCursorPosition(1, 1362); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[7]);

                //CURSO
                Console.SetCursorPosition(40, 1355); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[0]);
                Console.SetCursorPosition(40, 1356); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[1]);
                Console.SetCursorPosition(40, 1357); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[2]);
                Console.SetCursorPosition(40, 1358); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[3]);
                Console.SetCursorPosition(40, 1359); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[4]);
                Console.SetCursorPosition(40, 1360); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[5]);
                Console.SetCursorPosition(40, 1361); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[6]);
                Console.SetCursorPosition(40, 1362); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[7]);

                //PROMEDIO
                Console.SetCursorPosition(86, 1355); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum3CursosPromfin[0]);
                Console.SetCursorPosition(86, 1356); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum3CursosPromfin[1]);
                Console.SetCursorPosition(86, 1357); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum3CursosPromfin[2]);
                Console.SetCursorPosition(86, 1358); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum3CursosPromfin[3]);
                Console.SetCursorPosition(86, 1359); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum3CursosPromfin[4]);
                Console.SetCursorPosition(86, 1360); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum3CursosPromfin[5]);
                Console.SetCursorPosition(86, 1361); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum3CursosPromfin[6]);
                Console.SetCursorPosition(86, 1362); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum3CursosPromfin[7]);

                //ALUMNO
                Console.SetCursorPosition(1, 1364); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("ALUMNO: ");
                Console.SetCursorPosition(10, 1364); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(nom[3]);


                //PROMEDIO GENERAL
                double promGen3, sum3 = 0;
                sum3 += (Alum3CursosPromfin[0] + Alum3CursosPromfin[1] + Alum3CursosPromfin[2] + Alum3CursosPromfin[3] + Alum3CursosPromfin[4] + Alum3CursosPromfin[5] + Alum3CursosPromfin[6] + Alum3CursosPromfin[7]);
                promGen3 = sum3 / Alum3CursosPromfin.Length;

                Console.SetCursorPosition(1, 1366); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("PROMEDIO GENERAL: ");
                Console.SetCursorPosition(19, 1366); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write(promGen3);

                
                //-------------------------------------------------------------------------------------------------------------------------------------------------------
                //TABLA 5
                Console.SetCursorPosition(0, 1368); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("-----------------------------------------------------------------------------------------------");

                Console.SetCursorPosition(1, 1369); Console.ForegroundColor = ConsoleColor.Green; Console.Write("DOCENTE");
                Console.SetCursorPosition(40, 1369); Console.ForegroundColor = ConsoleColor.Green; Console.Write("UNIDAD DIDÁCTICA");
                Console.SetCursorPosition(86, 1369); Console.ForegroundColor = ConsoleColor.Green; Console.Write("PROMEDIO");


                Console.SetCursorPosition(0, 1370); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("-----------------------------------------------------------------------------------------------");

                //DOCENTE
                Console.SetCursorPosition(1, 1371); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[0]);
                Console.SetCursorPosition(1, 1372); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[1]);
                Console.SetCursorPosition(1, 1373); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[2]);
                Console.SetCursorPosition(1, 1374); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[3]);
                Console.SetCursorPosition(1, 1375); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[4]);
                Console.SetCursorPosition(1, 1376); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[5]);
                Console.SetCursorPosition(1, 1377); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[6]);
                Console.SetCursorPosition(1, 1378); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(prof[7]);

                //CURSO
                Console.SetCursorPosition(40, 1371); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[0]);
                Console.SetCursorPosition(40, 1372); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[1]);
                Console.SetCursorPosition(40, 1373); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[2]);
                Console.SetCursorPosition(40, 1374); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[3]);
                Console.SetCursorPosition(40, 1375); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[4]);
                Console.SetCursorPosition(40, 1376); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[5]);
                Console.SetCursorPosition(40, 1377); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[6]);
                Console.SetCursorPosition(40, 1378); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(cur[7]);

                //PROMEDIO
                Console.SetCursorPosition(86, 1371); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum4CursosPromfin[0]);
                Console.SetCursorPosition(86, 1372); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum4CursosPromfin[1]);
                Console.SetCursorPosition(86, 1373); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum4CursosPromfin[2]);
                Console.SetCursorPosition(86, 1374); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum4CursosPromfin[3]);
                Console.SetCursorPosition(86, 1375); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum4CursosPromfin[4]);
                Console.SetCursorPosition(86, 1376); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum4CursosPromfin[5]);
                Console.SetCursorPosition(86, 1377); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum4CursosPromfin[6]);
                Console.SetCursorPosition(86, 1378); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(Alum4CursosPromfin[7]);

                //ALUMNO
                Console.SetCursorPosition(1, 1380); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("ALUMNO: ");
                Console.SetCursorPosition(10, 1380); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(nom[4]);


                //PROMEDIO GENERAL
                double promGen4, sum4 = 0;
                sum4 += (Alum4CursosPromfin[0] + Alum4CursosPromfin[1] + Alum4CursosPromfin[2] + Alum4CursosPromfin[3] + Alum4CursosPromfin[4] + Alum4CursosPromfin[5] + Alum4CursosPromfin[6] + Alum4CursosPromfin[7]);
                promGen4 = sum4 / Alum4CursosPromfin.Length;

                Console.SetCursorPosition(1, 1382); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("PROMEDIO GENERAL: ");
                Console.SetCursorPosition(19, 1382); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write(promGen4);
                


                //Console.ReadKey();

                Console.SetCursorPosition(10, 1386); Console.Write("¿Deseas continuar? S/N: ");
                continuar = Convert.ToChar(Console.ReadLine().ToUpper());

                Console.Clear();
            }
            while (continuar == 'S');
        }
    }
}
