using System;
using System.Threading.Tasks;
using Julio.Business.Intefaces;
using Julio.Business.Models;
using Julio.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Julio.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}