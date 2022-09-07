using GraphQL_ASP.NET_Core_Web_API.DataAccess.Interface;

namespace GraphQL_ASP.NET_Core_Web_API.DataAccess.Repository
{
    public class SuperpowerRepository : ISuperpowerRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public SuperpowerRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
