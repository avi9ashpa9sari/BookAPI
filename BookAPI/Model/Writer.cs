using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookAPI.Model
{
    public class Writer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public ICollection<Book> Books { get; set; }
        public ICollection<BookCover> BookCovers { get; set; }

    }
}
