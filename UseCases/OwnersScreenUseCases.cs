using Core.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases
{
    public class OwnersScreenUseCases : IOwnersScreenUseCases
    {
        private readonly IOwnerRepository ownerRepository;

        public OwnersScreenUseCases(IOwnerRepository ownerRepository)
        {
            this.ownerRepository = ownerRepository;
        }

        public async Task<IEnumerable<Owner>> ViewOwnersAsync()
        {
            return await ownerRepository.GetAsync();
        }
    }
}