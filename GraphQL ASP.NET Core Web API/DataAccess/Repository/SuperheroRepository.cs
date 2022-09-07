using GraphQL_ASP.NET_Core_Web_API.DataAccess.Interface;

namespace GraphQL_ASP.NET_Core_Web_API.DataAccess.Repository
{
    public class SuperheroRepository : ISuperheroRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public SuperheroRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
