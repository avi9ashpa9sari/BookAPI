using BookAPI.Model;

namespace BookAPI.Repository
{
    public interface IBookRepository 
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> GetBookById(int id);
        Task<Book> Create(Book entity);
        Task Update(Book entity);
        Task Delete(int id);
    }
}
