using Library.Api.MockData;
using Library.Api.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Api.Repository
{
    public class MockBookRepository : IBookRepository
    {
        public Book CreateBook(Book book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book));
            if (book.Id == null)
                book.Id = Guid.NewGuid();
            LibraryMockData.Books.Add(book);
            return book;
        }

        public Book GetBook(Guid authorId, Guid id)
        {
            return LibraryMockData.Books.FirstOrDefault(x => x.Id == id && x.AuthorId == authorId);
        }

        public IEnumerable<Book> GetBookForAuthor(Guid authorId)
        {
            return LibraryMockData.Books.Where(x => x.AuthorId == authorId);
        }

        public IEnumerable<Book> GetBooks()
        {
            return LibraryMockData.Books;
        }
    }
}
