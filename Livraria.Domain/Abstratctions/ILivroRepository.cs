using Livraria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Abstratctions
{
    public interface ILivroRepository
    {
        Task<IEnumerable<Livro>> ObterLivros();
        Task<Livro> ObterLivro(int id);
        Task<Livro> AdicionarLivro(Livro livro);
        Task ObterLivros(int id);
        Task AtualizarLivro(Livro livro);
        Task DeletarLivro(int id);
    }
}
