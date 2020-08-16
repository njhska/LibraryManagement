using AutoMapper;
using System;
using System.Collections.Generic;
using Library.Api.Repository;
using Microsoft.AspNetCore.Mvc;
using Library.Api.Model;
using Library.Api.Entity;

namespace Library.Api.Controllers
{
    [Route("api/author/{authorId}/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository bookRepository;
        private readonly IAuthorRepository authorRepository;
        private readonly IMapper mapper;

        public BookController(IBookRepository bookRepository,IAuthorRepository authorRepository,IMapper mapper)
        {
            this.bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
            this.authorRepository = authorRepository ?? throw new ArgumentNullException(nameof(authorRepository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet(template:"")]
        public ActionResult<IEnumerable<BookDto>> GetBooks(Guid authorId)
        {
            var books = bookRepository.GetBookForAuthor(authorId);
            if (books == null)
                return NotFound();
            var result = mapper.Map<IEnumerable<BookDto>>(books);
            return Ok(result);
        }

        [HttpGet(template: "{bookId}",Name = nameof(GetBook))]
        public ActionResult<BookDto> GetBook(Guid authorId,Guid bookId)
        {
            var book = bookRepository.GetBook(authorId,bookId);
            if (book == null)
                return NotFound();
            var result = mapper.Map<BookDto>(book);
            return Ok(result);
        }
        [HttpPost]
        public ActionResult<BookDto> CreateBook([FromRoute]Guid authorId,[FromBody]BookAddDto bookAddDto)
        {
            if (!authorRepository.IsAuthorExist(authorId))
                return NotFound();
            var bookEntity = mapper.Map<Book>(bookAddDto);
            bookEntity.AuthorId = authorId;
            var result = bookRepository.CreateBook(bookEntity);
            return CreatedAtRoute(nameof(GetBook), new { authorId = authorId ,bookId = result.Id}, result);
        }
    }
}