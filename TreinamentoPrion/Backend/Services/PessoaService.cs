using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class PessoaService : GenericService<Pessoa>
    {
        public override List<Pessoa> ListAll()
        {
            List<Pessoa> lista = new List<Pessoa>();

            lista.Add(new Pessoa
            {
                PessoaId = 1,
                Nome = "Douglas Dono Olaria",
                Email = "douglinha_dono_de_olaria@boladao.com"
            });

            lista.Add(new Pessoa
            {
                PessoaId = 2,
                Nome = "Cristiano Dono Prion",
                Email = "cristianinho_do_po@boladao.com"
            });

            lista.Add(new Pessoa
            {
                PessoaId = 3,
                Nome = "Jeferson Dono INTL",
                Email = "jefinho@boladao.com"
            });

            lista.Add(new Pessoa
            {
                PessoaId = 4,
                Nome = "Romario Dono Cederj",
               Email = "romarinho_sem_mil_gols@boladao.com"
            });

            lista.Add(new Pessoa
            {
                PessoaId = 5,
                Nome = "Emilio Dono Cachoeiras",
                Email = "emilio@boladao.com"
            });

            return lista;
        }
    }
}
