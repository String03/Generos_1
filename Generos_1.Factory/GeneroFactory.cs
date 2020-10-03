using Generos_1.BLL;
using Generos_1.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generos_1.Factory
{
    public static class GeneroFactory
    {
        public static GeneroBLL CrearGenero()
        {
            return new GeneroBLL(new GeneroRepository());
        }
    }
}
