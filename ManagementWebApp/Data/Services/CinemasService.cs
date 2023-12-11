using ManagementWebApp.Data.Base;
using ManagementWebApp.Models;

namespace ManagementWebApp.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {

        public CinemasService(AppDbContext context) : base(context) { }

    }
}
