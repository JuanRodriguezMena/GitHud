using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LiquidacionCuotaModeradoraService persona = new LiquidacionCuotaModeradoraService();

            int op=0;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(20, 2); Console.Write("MENU PRINCIPAL");
                Console.SetCursorPosition(10, 5); Console.Write("1. Calcular liquidacion");
                Console.SetCursorPosition(10, 7); Console.Write("2. Consultar ");
                Console.SetCursorPosition(10, 9); Console.Write("3. Actualizar ");
                Console.SetCursorPosition(10, 9); Console.Write("4. Eliminar ");
                Console.SetCursorPosition(10, 11); Console.Write("5. Salir");
                Console.SetCursorPosition(20, 13); Console.Write("Seleccione una opción:");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Ingrese numero de liquidacion: ");
                        int n_liquidacion = int.Parse(Console.ReadLine());
                        Console.WriteLine("Fecha : ");
                        DateTime fecha_liquidacion = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Cedula: ");
                        string cedula = Console.ReadLine();
                        Console.WriteLine("Salario: ");
                        double salario = double.Parse(Console.ReadLine());
                        Console.WriteLine("Valor del servicio de hospitalización prestado: ");
                        double v_hospital = double.Parse(Console.ReadLine());
                        Console.WriteLine("Eres Subsidiado? : ");
                        Console.WriteLine("1.NO ");
                        Console.WriteLine("2.SI ");
                        int r1 = int.Parse(Console.ReadLine());
                        Boolean tipo = false;
                        string tipo_afiliacion;
                        if (r1 == 1)
                        {
                            tipo = true;
                            tipo_afiliacion = "Contributivo";
                        }
                        else
                        {

                            tipo_afiliacion = "Subsidiado";
                        }

                        LiquidacionCuotaModeradora j = new LiquidacionCuotaModeradora(n_liquidacion, fecha_liquidacion, cedula, salario, v_hospital, tipo_afiliacion, tipo);

                        Console.WriteLine(persona.Guardar(persona.CalcularLiquidacion(j)));
                        Console.ReadKey();

                        break;
                    case 2:
                        MostrarUsuarios();
                        Console.Clear();
                        break;
                    case 3:
                        
                        break;
                    case 4:
                       
                        break;
                    case 5:
                        Environment.Exit(0);

                        break;

                }

            } while (op!=5);

            private void MostrarUsuarios()
            {
                Console.Clear();
                Console.SetCursorPosition(15, 2); Console.Write("Listado");
                Console.SetCursorPosition(10, 4); Console.Write("N_liquidacion");
                Console.SetCursorPosition(28, 4); Console.Write("Fecha_liqudacion");
                Console.SetCursorPosition(40, 4); Console.Write("Cedula");
                Console.SetCursorPosition(46, 4); Console.Write("Salario");
                Console.SetCursorPosition(56, 4); Console.Write("Valor_hospital");
                Console.SetCursorPosition(66, 4); Console.Write("Tipo_afilicaion");
                Console.SetCursorPosition(76, 4); Console.Write("Tipo");
                Console.SetCursorPosition(86, 4); Console.Write("Liquidacion");
                int posicion = 2;
                foreach (var item in LiquidacionCuotaModeradoraService.C)
                {

                    Console.SetCursorPosition(15, 4 + posicion); Console.Write(item.Identificacion);
                    Console.SetCursorPosition(29, 4 + posicion); Console.Write(item.Nombre);
                    Console.SetCursorPosition(42, 4 + posicion); Console.Write(item.Edad);
                    Console.SetCursorPosition(48, 4 + posicion); Console.Write(item.Sexo);
                    Console.SetCursorPosition(59, 4 + posicion); Console.Write(item.Pulsacion);
                    posicion++;
                }
                Console.ReadKey();
            }

        }
    }
}

//oewfiuwaiufnhiufhioafjopijowiejfojwoi