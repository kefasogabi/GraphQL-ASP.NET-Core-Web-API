using GraphQL_ASP.NET_Core_Web_API.DataAccess.Models;

namespace GraphQL_ASP.NET_Core_Web_API.DataAccess
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Superhero> GetSuperheroes([Service] ApplicationDbContext context) =>
            context.Superheroes;
    }
}
