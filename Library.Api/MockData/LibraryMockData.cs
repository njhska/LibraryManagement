using Library.Api.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Api.MockData
{
    public class LibraryMockData
    {
        public static IList<Author> Authors = new List<Author> {
                new Author {
                    Id=new Guid("F3EE6CE8-4BD6-4DD2-9F49-E917783202B9"),
                    Name="Author1",
                    Age=44,
                    Email="author1@xxx.com"
                },
                new Author {
                    Id=new Guid("7B3007B0-9FB8-439F-A5DF-3CF0242015B6"),
                    Name="Author2",
                    Age=54,
                    Email="author2@xxx.com"
                }
            };
        public static IList<Book> Books = new List<Book>
            {
                new Book{
                Id=new Guid("1589029B-5D05-4179-A862-70D9E8B6175B"),
                Name="Book1",
                Pages=1000,
                Description="Description of Book1",
                AuthorId = new Guid("F3EE6CE8-4BD6-4DD2-9F49-E917783202B9")
                },
                new Book{
                Id=new Guid("4CB80CFD-104D-472A-9527-2EBA039125E2"),
                Name="Book2",
                Pages=999,
                Description="Description of Book2",
                AuthorId = new Guid("F3EE6CE8-4BD6-4DD2-9F49-E917783202B9")
                },
                new Book{
                Id=new Guid("990AC040-0F0B-47BD-A73E-ED03BA72482C"),
                Name="Book3",
                Pages=567,
                Description="Description of Book3",
                AuthorId = new Guid("F3EE6CE8-4BD6-4DD2-9F49-E917783202B9")
                },
                new Book{
                Id=new Guid("12F79E1F-D699-4959-BBB2-DAFB383CA4BC"),
                Name="Book4",
                Pages=678,
                Description="Description of Book4",
                AuthorId = new Guid("F3EE6CE8-4BD6-4DD2-9F49-E917783202B9")
                },
                new Book{
                Id=new Guid("DC9FB8C7-5491-4F46-9E4C-FA497DED6C82"),
                Name="Book5",
                Pages=987,
                Description="Description of Book5",
                AuthorId = new Guid("F3EE6CE8-4BD6-4DD2-9F49-E917783202B9")
                },
                new Book{
                Id=new Guid("5F03BC81-1677-45C1-8EFE-34D5B2E36FCF"),
                Name="Book6",
                Pages=34534,
                Description="Description of Book6",
                AuthorId = new Guid("7B3007B0-9FB8-439F-A5DF-3CF0242015B6")
                },
                new Book{
                Id=new Guid("E7D433E7-F4E2-4F25-86E0-46AC39484C5A"),
                Name="Book7",
                Pages=23423,
                Description="Description of Book7",
                AuthorId = new Guid("7B3007B0-9FB8-439F-A5DF-3CF0242015B6")
                },
                new Book{
                Id=new Guid("4F2AE85B-11EC-4B59-B78E-3996C8A239D6"),
                Name="Book8",
                Pages=5345,
                Description="Description of Book8",
                AuthorId = new Guid("7B3007B0-9FB8-439F-A5DF-3CF0242015B6")
                },
                new Book{
                Id=new Guid("F2D378EA-AE5E-415B-BC00-8512953B70D8"),
                Name="Book9",
                Pages=456,
                Description="Description of Book9",
                AuthorId = new Guid("7B3007B0-9FB8-439F-A5DF-3CF0242015B6")
                },
                new Book{
                Id=new Guid("4F88134E-97B9-4F55-90D9-307A1B2B1C93"),
                Name="Book10",
                Pages=6456,
                Description="Description of Book10",
                AuthorId = new Guid("7B3007B0-9FB8-439F-A5DF-3CF0242015B6")
                }
            };

    }
}
