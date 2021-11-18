using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class PizzaMuzzarellaBuilder:PizzaBuilder
    {
        public PizzaMuzzarellaBuilder()
        {
            descripcion = "Pizza Muzza";
        }

        public override Agregado BuildAgregado()
        {
            return new Oregano();
        }

        public override Masa BuildMasa()
        {
            return new AlMolde();
        }

        public override Salsa BuildSalsa()
        {
            return new Tomate();
        }
    }
}
