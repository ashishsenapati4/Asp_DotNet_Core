using ModelsInAspCore.Models;

namespace ModelsInAspCore.Repository
{
    public interface IBook
    {
        public List<BookModel> GetAllBooks();

        public BookModel BookById(int BookId);
    }
}
