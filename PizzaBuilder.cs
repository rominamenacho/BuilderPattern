using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
   public abstract class PizzaBuilder
    {
        protected string descripcion;
        public abstract Masa BuildMasa();
        public abstract Agregado BuildAgregado();

        public abstract Salsa BuildSalsa();

        public override string ToString()
        {
            return descripcion;
        }

        public Pizza BuildPizza()
        {
            Masa masa = BuildMasa();
            Agregado agregado = BuildAgregado();
            Salsa salsa = BuildSalsa();

            return  new Pizza(agregado, masa, salsa, descripcion);
        }
    }
}
