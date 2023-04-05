using System.ComponentModel.DataAnnotations.Schema;

namespace BookAPI.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string BookUrl { get; set; }
        public bool Trending { get; set; }

        public DateTime CreatedDate { get; set; }
        public string ISBNNumber { get; set; }
        public IFormFile ImageFile { get; set; }
        public IFormFile BookFile { get; set; }
        [NotMapped]
        public int? BookCoverId { get; set; }
        [NotMapped]
        public int? BookWriterId { get; set; }
    }
}
