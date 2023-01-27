using BookAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookContext bookContext;

        public BookRepository(BookContext bookContext)
        {
            this.bookContext = bookContext;
        }
        public async Task<Book> Create(Book entity)
        {
            bookContext.Books.Add(entity);
            await bookContext.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(int id)
        {
            var bookToDelete = bookContext.Books.FindAsync(id);
            bookContext.Remove(bookToDelete);
            await bookContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await bookContext.Books.ToListAsync();
        }

        public async Task<Book> GetBookById(int id)
        {
            return await bookContext.Books.FindAsync(id);
        }

        public async Task Update(Book entity)
        {
            bookContext.Entry(entity).State = EntityState.Modified;
            await bookContext.SaveChangesAsync();
        }
    }
}
