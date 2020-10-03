using Generos_1.EE;
using Generos_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generos_1.BLL
{
    public class GeneroBLL
    {
        private readonly IGeneroRepository generoRepository;

        public GeneroBLL(IGeneroRepository generoRepository)
        {
            this.generoRepository = generoRepository;
        }
        
        public IEnumerable<Genero> ListarGeneros()
        {
            return generoRepository.ListarGenero();
        }

        public void Alta(Genero genero)
        {
            generoRepository.Alta(genero); 
        }

        public void Baja(Genero genero)
        {
            generoRepository.Baja(genero);
        }

        public void Modificacion(Genero genero)
        {
            generoRepository.Modificacion(genero);
        }
    }
}
