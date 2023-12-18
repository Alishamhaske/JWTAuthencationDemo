using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JWTAuthencationDemo.Model
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int Id { get;set; }

        public string? Name { get; set; }
        public string? Author { get; set; }
        public int Price { get; set; }
    }
}
