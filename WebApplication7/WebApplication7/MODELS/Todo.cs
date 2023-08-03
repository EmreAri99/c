using System.ComponentModel.DataAnnotations;

namespace WebApplication7.MODELS
{
    public class Todo : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}

