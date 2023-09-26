using Dato;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LiquidacionCuotaModeradoraService
    {
        LiquidacionCuotaModeradoraRepository repo = new LiquidacionCuotaModeradoraRepository();
    
        List<LiquidacionCuotaModeradora> lista= new List<LiquidacionCuotaModeradora> ();

        public List<LiquidacionCuotaModeradora> Consultar()
        {
            lista=repo.ConsultarTodos();
            return lista;
        }

        public string Guardar(LiquidacionCuotaModeradora liquidacion)
        {
             
            var msg = repo.CrearArchivo(liquidacion);
            lista = repo.ConsultarTodos();
            return msg;
        }

        public LiquidacionCuotaModeradora CalcularLiquidacion(LiquidacionCuotaModeradora persona)
        {
            double SalarioMinimo = 1300000;
            
            double tarifa = 0;
            if (persona.Tipo==true)
            {
                if (persona.Salario<SalarioMinimo*2)
                {
                    tarifa = 0.15;
                    persona.Liquidacion = (persona.Valor_hospital * tarifa);
                }
                else
                {
                    if (persona.Salario>=SalarioMinimo*5)
                    {
                        tarifa = 0.20;
                        persona.Liquidacion = (persona.Valor_hospital * tarifa);
                    }
                    else
                    {
                        tarifa=0.25;
                        persona.Liquidacion = (persona.Valor_hospital * tarifa);
                    }
                }
            }
            return persona;
        }







    }
}
