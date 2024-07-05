using eTickets.Data.Base;
using eTickets.Data.Enum;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public class ProducersService: EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
