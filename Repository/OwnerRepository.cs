using Repository.ApiClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly IWebApiExecuter webApiExecuter;

        public OwnerRepository(IWebApiExecuter webApiExecuter)
        {
            this.webApiExecuter = webApiExecuter;
        }

        public async Task<IEnumerable<Owner>> GetAsync()
        {
            return await webApiExecuter.InvokeGet<IEnumerable<Owner>>("api/owners");
        }

        public async Task<Owner> GetByIdAsync(int id)
        {
            return await webApiExecuter.InvokeGet<Owner>($"api/owners/{id}");
        }

        public async Task<IEnumerable<Ticket>> GetOwnerTicketsAsync(int ownerId, string filter = null)
        {
            string uri = $"api/owners/{ownerId}/tickets";
            if (!string.IsNullOrWhiteSpace(filter))
                uri += $"?owner={filter}&api-version=2.0";

            return await webApiExecuter.InvokeGet<IEnumerable<Ticket>>(uri);
        }

        //public async Task<int> CreateAsync(Owner owner)
        //{
        //    owner = await webApiExecuter.InvokePost("api/owners", owner);
        //    return owner.OwnerId;
        //}

        //public async Task UpdateAsync(Owner owner)
        //{
        //    await webApiExecuter.InvokePut($"api/owners/{owner.OwnerId}", owner);
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await webApiExecuter.InvokeDelete($"api/owners/{id}");
        //}
    }
}

