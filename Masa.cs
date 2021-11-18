using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
   public abstract class Masa
    {
        protected string descripcion;
        public string Descripcion { get { return descripcion; } }
    }

    public class AlMolde : Masa
    {
        public AlMolde()
        {
            descripcion = "Masa al molde";
        }
    }

    public class Integral : Masa { 
    
    public Integral()
        {
            descripcion = "Masa con harina integral";
        }
    }

    public class AlaPiedra : Masa
    {
        public AlaPiedra()
        {
            descripcion = "Masa a la piedra en horno de barro";
        }

    }
        
      
}
