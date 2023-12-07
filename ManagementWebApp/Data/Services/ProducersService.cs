using ManagementWebApp.Data.Base;
using ManagementWebApp.Models;

namespace ManagementWebApp.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context) { }
    }
}
