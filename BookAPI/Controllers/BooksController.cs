using BookAPI.Model;
using BookAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository context;

        public BooksController(IBookRepository context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await context.GetAllBooks();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            return await context.GetBookById(id);
        }

        [HttpPost]
        public async Task<ActionResult<Book>> Create([FromBody] Book book)
        {
            var newBook = await context.Create(book);
            return CreatedAtAction(nameof(GetBooks), new { id = newBook.Id }, newBook);
        }
    }
}
