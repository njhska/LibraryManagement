using Library.Api.Entity;
using System;
using System.Collections.Generic;

namespace Library.Api.Repository
{
    public interface IBookRepository
    {
        Book GetBook(Guid authorId, Guid id);
        IEnumerable<Book> GetBooks();
        IEnumerable<Book> GetBookForAuthor(Guid authorId);
        Book CreateBook(Book book);
    }
}
