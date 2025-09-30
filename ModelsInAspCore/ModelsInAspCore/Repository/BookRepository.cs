using ModelsInAspCore.Models;

namespace ModelsInAspCore.Repository
{
    public class BookRepository : IBook
    {

        public BookRepository() { }

        public List<BookModel> GetAllBooks()
        {
            return BookData();
        }

        public BookModel BookById(int BookId)
        {
            return BookData().Where(x => x.BookId == BookId).FirstOrDefault();
        }

        private List<BookModel> BookData()
        {
            return new List<BookModel>
            {
                new BookModel {BookId = 111, BookName = "Harry Potter", BookDescription = "Magical", BookPrice = 7890},
                new BookModel {BookId = 222, BookName = "GOT", BookDescription = "Fantasy", BookPrice = 8999},
                new BookModel {BookId = 333, BookName = "Breaking Bad", BookDescription = "Crime", BookPrice = 6999},
            };
        }
    }
}
