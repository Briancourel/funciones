using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace funciones
{
    internal class Program
    {
        static int numero;
        static int cubo;
        static int cuadrado;    
        static void Main(string[] args)
        {
            // PUNTO UNO, BIENVENIDA AL CLIENTE Y SU EDAD.

            /*  int edad;
              string nombre;

              ImprimirBienvenidaDatos();



              void Bienvenida() 
              {
                  Console.WriteLine("Bienvenid@ al programa ");
                  Console.WriteLine(" Nombre : " + nombre);
                  Console.WriteLine(" Edad : " + edad);

              }

              void PedirDatos()
              {
                  Console.Write(" ingrese su nombre: ");
                  nombre = Console.ReadLine();
                  Console.Write(" ingrese su edad: ");
                  edad = int.Parse(Console.ReadLine());
              }

              void ImprimirBienvenidaDatos() 
              {
                 PedirDatos();
                 Bienvenida();
              }

             //PUNTO DOS, CUADRADO DE UN NUMERO

             int numero = 0;
             string opcion;

             int CalcularCuadrado(int numeroX2)
             {
                  return numero * numero;

             }



             do // lo hice con (do) porque no logro hacer que "n" tambien se almacene como una opcion y no solo como un numero 
             {
                 Console.Write(" Ingrese un nuemero de un digito (0-9) o 'N' para salir: ");
                 numero = int.Parse(Console.ReadLine());



                 CalcularCuadrado(numero);
                 Console.WriteLine(value: $"{numero} al cuadrado es {CalcularCuadrado(numero)}");



             } while (numero != 'n');


             // PUNTO TRES, PRACTICA

             void MostrarBienvenida() 
             {
                Console.WriteLine(" bienvenido al programa");
             }
             void MostrarInstrucciones() 
             {
              Console.WriteLine(" Por favor, siga las siguientes instrucciones... ");
              Console.WriteLine(" 1) meta sus manos debajo la canilla y deje correr el agua");
              Console.WriteLine(" 2) una vez que el agua este tibia ( si lo desea) frotar el jabon con ambas manos");
              Console.WriteLine(" 3) enjuagar las manos nuevamente con agua");
              Console.WriteLine(" 4) secar las manos con una toalla o papel");
              Console.WriteLine( " FELICIDADES APRENDISTE A LAVARTE LAS MANOS!!!");
             }

             MostrarBienvenida();
             MostrarInstrucciones();

             // PUNTO CUATRO, SALUDO Y NOMBRE

             string nombre;

             void MostrarSaludo(string nombreYSaludo) 
             {
                 Console.WriteLine(" Hola " + nombreYSaludo + " bienvenido a este programa");
             }
             void SolicitarNombre() 
             {
               Console.WriteLine(" ingrese su nombre ");
                nombre = Console.ReadLine();

             }

             SolicitarNombre();
             MostrarSaludo(nombre);

            // PUNTO CINCO, REALIZAR 10 SUMAS Y PRODUCTOS

            
            
            int suma = 0;

           

            void CalcularSuma (int a, int b, int c) 
            { 
                suma = a + b + c;
                Console.WriteLine(" La suma de los numero es: " + suma);
            }

            void CalcularProducto(  int a, int b, int c ) 
            {
              Console.WriteLine("El procuto de los numero es: " + 
                  a * b * c);
            }

            void SolicitarNumeros()

            {
                int a, b, c;
                Console.Write(" ingrese el primer numero ");
                a = int.Parse(Console.ReadLine());
                Console.Write(" ingrese el segundo numero ");
                b = int.Parse(Console.ReadLine());
                Console.Write(" ingrese el tercer numero ");
                c = int.Parse(Console.ReadLine());
                CalcularSuma(a, b, c);
                CalcularProducto (a, b, c);
            }

            for (int i = 1; i <= 10;  i++) 
            {
             SolicitarNumeros();
            }

            //PUNTO SEIS CALCULOS GEOMETRICOS

 
            double radio;

            double largo1;
            double ancho1;
            string opcion6;

            double CalcularAreaCirculo(double area)
            {
                area = 3.14 * radio * radio;
                return area;
            }

            double CalcularAreaRectangulo(double largo, double ancho)
            {
                double areaRec = largo1 * ancho1;
                return areaRec;
            }

            do
            {
                Console.Write(" ingrese el radio del circulo: ");
                radio = double.Parse(Console.ReadLine());
                Console.WriteLine($" el area del circulo es: {CalcularAreaCirculo(radio)}");


                Console.Write(" ingrese el largo del rectangulo:");
                largo1 = double.Parse(Console.ReadLine());
                Console.Write(" ingrese el ancho del rectangulo:");
                ancho1 = double.Parse(Console.ReadLine());

                Console.WriteLine($" el area de un rectangulo es: {CalcularAreaRectangulo(largo1, ancho1)} ");

                Console.WriteLine(" desea realizar otro calculo ( s/n )");
                opcion = Console.ReadLine().ToLower();



                if ( opcion != "n" && opcion != "s") 
                {
                    Console.WriteLine(" tecla invalida se interpreto como 'n'");
                   

                }

                

            } while (opcion == "s");
            

            // PUNTO SIETE, DESARROLLO VERSATIL CON MULTIPLES METODOS

                int LeerElNumero()
                {
                    Console.Write(" ingrese un numero : ");
                    return int.Parse(Console.ReadLine());
                
                }

                bool EsPar(int numero)
                {
                    return numero % 2 == 0 ;
                }

                int CalcularCuadrado(int numero)
                {
                    return numero * numero ;
                }

                int CalcularCubo(int numero)
                {
                     return numero * numero * numero;
                }

           
                void MostrarResultados()
            {
                int numero;
                numero = LeerElNumero();

                if (EsPar(numero)) 
                {
                    Console.WriteLine(" el numero " + numero + " es par");
                }
                else
                {
                    Console.WriteLine(" el numero " + numero + " es impar");
                }

                Console.WriteLine(" el cuadrado del numero es " + CalcularCuadrado(numero));
                Console.WriteLine(" el cubo del numero es " + CalcularCubo(numero));

            }

            MostrarResultados();*/

            //PUNTO OCHO CALCULADORA

            int numero1;
            int numero2;
            int opcion;
            string opcion1;
            int resultado;
            
            void PedirNumeros()
            {
                Console.WriteLine(" ingrese el primer numero");
                 numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine(" ingrese el segundo numero ");
                 numero2 = int.Parse(Console.ReadLine());
            }

            void MenuDeOpciones() 
            {
             Console.WriteLine(" SEGUN LA OPERACION SELECCIONE UNA OPCION");
                Console.WriteLine(" 1) SUMA");
                Console.WriteLine(" 2) RESTA");
                Console.WriteLine(" 3) MULTIPLICACION");
                Console.WriteLine(" 4) DIVISION");

                opcion = int.Parse(Console.ReadLine());
          
            }
            int Suma () 
            {
               return numero1 + numero2;
            }
            int Resta() 
            {
             return numero1 - numero2;
            }
            int Multiplic () 
            {
                return numero1 * numero2; 
            }
            int Division() 
            {
             return (numero1 / numero2);
            }

            
            

            do
            {

                PedirNumeros();
                MenuDeOpciones();

                switch (opcion)
                {
                    case 1: Console.WriteLine(" la suma de los numero es: " + Suma()); break;
                    case 2: Console.WriteLine(" la resta de los numero es: " + Resta()); break;
                    case 3: Console.WriteLine(" la multiplicacion de los numero es: " + Multiplic()); break;
                    case 4: Console.WriteLine(" la division de los numero es: " + Division()); break;
                    default: Console.WriteLine(" opcion invalida"); break;
                }

                Console.WriteLine(" desea hacer otra operacion (s/n)");
                opcion1 = Console.ReadLine();
            } while (opcion1 != "n");















































        }

    }
}
