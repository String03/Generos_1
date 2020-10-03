using Generos_1.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generos_1.Interfaces
{
    public interface IGeneroRepository
    {
        void Alta(Genero genero);
        void Baja(Genero genero);
        void Modificacion(Genero genero);
        IEnumerable<Genero> ListarGenero();
    }
}
