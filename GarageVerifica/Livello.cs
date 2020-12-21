using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageVerifica
{
    public class Livello
    {
        public int Numero { get; private set; }
        public List<Parcheggio> Parcheggi { get; private set; }

        public Livello(int numero, Garage garage)
        {
            Numero = numero;
            garage.Livelli.Add(this);
        }
    }
}
