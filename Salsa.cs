using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
   public abstract class Salsa
    {
        protected string descripcion;
        public string Descripcion { get { return descripcion; } }

        public Salsa() { }
    }

    public class Tomate : Salsa
    {
        public Tomate()
        {
            descripcion = "Salsa de tomate";
        }
    }

    public class Oliva : Salsa
    {
        public Oliva()
        {
            descripcion = "Salsa de olivas negras";
        }
    }

    public class Light : Salsa
    {
        public Light()
        {
            descripcion = "Salsa light sin aceite";
        }
    }




}
