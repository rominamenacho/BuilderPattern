using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Pizza
    {
        private Agregado agregado;
        private Masa masa;
        private Salsa salsa;
        private string tipo;

        public Pizza(Agregado _agregado, Masa _masa, Salsa _salsa, string _tipo)
        {
            this.agregado = _agregado;
            this.masa = _masa;
            this.salsa = _salsa;
            this.tipo = _tipo;
        }

        public override string ToString()
        {
            return $"{tipo},  {masa.Descripcion},  {salsa.Descripcion},  {agregado.Descripcion}";
        }
    }
}
