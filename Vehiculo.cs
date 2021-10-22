using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    class Vehiculo
    {
            public void arrancaMotor()
            {
                Console.WriteLine("Motor arrancado ");
            }

            public void pararMotor()
            {
                Console.WriteLine("Frenando ");
            }

            public virtual void conducir()
            {
                Console.WriteLine("Conduciendo Vehiculo");
            }

        
    }
}
