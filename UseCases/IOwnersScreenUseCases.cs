using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCases
{
    public interface IOwnersScreenUseCases
    {
        Task<IEnumerable<Owner>> ViewOwnersAsync();
    }
}