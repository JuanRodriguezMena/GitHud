using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LiquidacionCuotaModeradora
    {
        

        public int N_liquidacion { get; set; }
        public DateTime Fecha_liqudacion { get; set; }

        public string Cedula { get; set; }


        public double Salario { get; set; }

        public double Valor_hospital { get; set; }

    
        public string Tipo_afilicaion { get; set; }

        public Boolean Tipo {  get; set; }

        public double Liquidacion { get; set; }


        public LiquidacionCuotaModeradora()
        {

        }

        

        public LiquidacionCuotaModeradora(int n_liquidacion, DateTime fecha_liquidacion, string cedula, double salario, double v_hospital, string tipo_afiliacion, Boolean tipo)
        {
            N_liquidacion = n_liquidacion;
            Fecha_liqudacion= fecha_liquidacion;
            Cedula = cedula;
            Salario = salario;
            Valor_hospital = v_hospital;
            Tipo_afilicaion = tipo_afiliacion;
            Tipo = tipo;
            
           
        }



        //public float CalcularLiquidacion(LiquidacionCuotaModeradora persona)
        //{
        //    float liquidacion = 0;
        //    if ()
        //    {

        //    }
        //    return 
        //}
    }
}
