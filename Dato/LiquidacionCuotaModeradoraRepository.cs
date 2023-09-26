using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Dato
{
    public class LiquidacionCuotaModeradoraRepository
    {
        string fileName = "liquidación de la cuota moderadora";

        public string CrearArchivo(LiquidacionCuotaModeradora liquidacion)
        {
            var escritor = new StreamWriter(fileName, true);

            escritor.WriteLine(liquidacion.ToString());

            escritor.Close();

            return "Creado con exito";
      
        }

    
    
        public List<LiquidacionCuotaModeradora> ConsultarTodos()
        {
            List<LiquidacionCuotaModeradora> liqudacion = new List<LiquidacionCuotaModeradora>();
            try
            {
                StreamReader lector = new StreamReader(fileName);
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    liqudacion.Add(Map(linea));

                }
                lector.Close();

                return liqudacion;
            }
            catch (Exception)
            {
                return null;
            }

        }

        private LiquidacionCuotaModeradora Map(string linea)
        {
            LiquidacionCuotaModeradora p = new LiquidacionCuotaModeradora();
            var datos = linea.Split(';');
            p.N_liquidacion = int.Parse(datos[0]);
            p.Fecha_liqudacion = DateTime.Parse(datos[1]);
            p.Cedula = (datos[2]);
            p.Salario = float.Parse(datos[3]);
            p.Valor_hospital = float.Parse(datos[4]);
            p.Tipo_afilicaion = (datos[5]);
            return p;
        }








    }
}
