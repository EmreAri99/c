using System.ComponentModel.DataAnnotations;

namespace WebApplication7.MODELS
{
    public class Category : BaseEntity
    {

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Todo> Todos { get; set; }
    }
}
