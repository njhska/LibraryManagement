using AutoMapper;
using Library.Api.Entity;
using Library.Api.Model;
using System;

namespace Library.Api.AutoMapper
{
    public class LibraryProfile:Profile
    {
        public LibraryProfile()
        {
            CreateMap<Author, AuthorDto>();
            CreateMap<Book, BookDto>();
            CreateMap<AuthorAddDto, Author>();
            CreateMap<BookAddDto, Book>();
        }
    }
}
