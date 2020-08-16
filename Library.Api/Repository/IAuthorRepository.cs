using Library.Api.Entity;
using System;
using System.Collections.Generic;

namespace Library.Api.Repository
{
    public interface IAuthorRepository
    {
        Author GetAuthor(Guid id);
        IEnumerable<Author> GetAuthors();
        bool IsAuthorExist(Guid id);

        Author CreateAuthor(Author author);
    }
}
