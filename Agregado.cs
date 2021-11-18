using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
  public abstract class Agregado
    {
        protected string descripcion;
        public string Descripcion { get { return descripcion; } }


    }


    public class Oregano : Agregado
    {
        public Oregano()
        {
            descripcion = "Agregado de oregano fresco";
        }
    }

    public class Anchoas: Agregado
    {
        public Anchoas()
        {
            descripcion = "Agregado de anchoas al aceite";
        }
    }

    public class Berenjenas : Agregado
    {
        public Berenjenas()
        {
            descripcion = "Agregado de berenjenas en escabeche";
        }
    }
}
