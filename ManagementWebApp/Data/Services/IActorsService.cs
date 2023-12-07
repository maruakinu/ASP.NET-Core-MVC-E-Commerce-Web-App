using ManagementWebApp.Models;

namespace ManagementWebApp.Data.Services
{
    public interface IActorsService
    {
        //Task is for Asynchrounous if you dont want it as Asynch just remove Task<> 
        Task<IEnumerable<Actor>> GetAllAsync();

        Task<Actor> GetByIdAsync(int id);

        Task AddAsync(Actor actor);

        Task<Actor> UpdateAsync(int id, Actor newActor);

        Task DeleteAsync(int id);
    }
}
