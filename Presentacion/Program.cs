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
                Console.SetCursorPosition(10, 11); Console.Write("4. Salir");
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
                        int r1=int.Parse(Console.ReadLine());
                        Boolean tipo=false;
                        string tipo_afiliacion;
                        if (r1==1)
                        {
                            tipo = true;
                            tipo_afiliacion = "Contributivo";
                        }
                        else
                        {
                            
                            tipo_afiliacion = "Subsidiado";
                        }

                        LiquidacionCuotaModeradora j = new LiquidacionCuotaModeradora(n_liquidacion,fecha_liquidacion,cedula,salario,v_hospital,tipo_afiliacion, tipo);
 
                        Console.WriteLine(persona.Guardar(persona.CalcularLiquidacion(j)));
                        Console.ReadKey();  

                        break;

                    case 4:
                        Environment.Exit(0);

                        break;

                }

            } while (op!=4);

           
        }
    }
}

//oewfiuwaiufnhiufhioafjopijowiejfojwoi