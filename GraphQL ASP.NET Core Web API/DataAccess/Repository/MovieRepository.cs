using GraphQL_ASP.NET_Core_Web_API.DataAccess.Interface;

namespace GraphQL_ASP.NET_Core_Web_API.DataAccess.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public MovieRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
