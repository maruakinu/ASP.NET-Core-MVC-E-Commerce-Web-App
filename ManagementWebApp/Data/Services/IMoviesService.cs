using ManagementWebApp.Data.Base;
using ManagementWebApp.Data.ViewModels;
using ManagementWebApp.Models;

namespace ManagementWebApp.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();

        Task AddNewMovieAsync(NewMovieVM data);

        Task UpdateMovieAsync(NewMovieVM data);
    }
}
