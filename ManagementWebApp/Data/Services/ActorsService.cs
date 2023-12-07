using ManagementWebApp.Data.Base;
using ManagementWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ManagementWebApp.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {

        public ActorsService(AppDbContext context) : base(context) { }
       
    }
}
