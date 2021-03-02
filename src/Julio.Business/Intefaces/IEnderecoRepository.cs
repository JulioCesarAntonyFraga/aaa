using System;
using System.Threading.Tasks;
using Julio.Business.Models;

namespace Julio.Business.Intefaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}