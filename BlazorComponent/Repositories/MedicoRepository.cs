using BlazorComponent.Models;

namespace BlazorComponent.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        public async Task<List<Medico>> GetAllAsync()
        {
            return new List<Medico>
            {
                new Medico { Id = 1, Nome = "Dr. João", Crm = "123456" },
                new Medico { Id = 2, Nome = "Dr. José", Crm = "654321" },
                new Medico { Id = 3, Nome = "Dr. Maria", Crm = "987654" },
                new Medico { Id = 4, Nome = "Dr. Ana", Crm = "456789" },
                new Medico { Id = 5, Nome = "Dr. Pedro", Crm = "321654" }
            };
        }
    }
}
