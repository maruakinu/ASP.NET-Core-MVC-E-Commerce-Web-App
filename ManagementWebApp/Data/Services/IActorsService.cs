using ManagementWebApp.Models;

namespace ManagementWebApp.Data.Services
{
    public interface IActorsService
    {
        //Task is for Asynchrounous if you dont want it as Asynch just remove Task<> 
        Task<IEnumerable<Actor>> GetAll();

        Actor GetById(int id);

        void Add(Actor actor);

        Actor Update(int id, Actor newActor);

        void Delete(int id);
    }
}
