using Library.Api.MockData;
using Library.Api.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Api.Repository
{
    public class MockAuthorRepository : IAuthorRepository
    {
        public Author CreateAuthor(Author author)
        {
            if (author == null)
                throw new ArgumentNullException(nameof(author));
            if (author.Id == Guid.Empty)
                author.Id = Guid.NewGuid();
            LibraryMockData.Authors.Add(author);
            return author;
        }

        public Author GetAuthor(Guid id)
        {
            return LibraryMockData.Authors.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Author> GetAuthors()
        {
            return LibraryMockData.Authors;
        }

        public bool IsAuthorExist(Guid id)
        {
            return LibraryMockData.Authors.Any(x => x.Id == id);
        }
    }
}
