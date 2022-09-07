using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQL_ASP.NET_Core_Web_API.DataAccess.Models
{
    public class Movie
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The movie title is required")]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Instructor { get; set; }
        public DateTime ReleaseDate { get; set; }

        [ForeignKey("SuperheroId")]
        public Guid SuperheroId { get; set; }
        public Superhero Superhero { get; set; }
    }
}
