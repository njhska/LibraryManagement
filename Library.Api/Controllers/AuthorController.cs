using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Library.Api.Model;
using Library.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Library.Api.Entity;

namespace Library.Api.Controllers
{
    [Route("api/Author")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository authorRepository;
        private readonly IMapper mapper;

        public AuthorController(IAuthorRepository authorRepository,IMapper mapper)
        {
            this.authorRepository = authorRepository ??
                                        throw new ArgumentNullException(nameof(authorRepository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        [HttpGet(template: "")]
        [HttpHead]
        public ActionResult<IEnumerable<AuthorDto>> GetAuthors()
        {
            //throw new Exception("exception");

            var authors = authorRepository.GetAuthors();

            var result = mapper.Map<IEnumerable<AuthorDto>>(authors);

            return Ok(result);
        }
        [HttpGet(template:"{id}",Name = nameof(GetAuthor))]
        public ActionResult<AuthorDto> GetAuthor(Guid id)
        {
            var author = authorRepository.GetAuthor(id);
            if (author == null)
                return NotFound();
            var result = mapper.Map<AuthorDto>(author);
            return Ok(result);
        }
        [HttpPost]
        public ActionResult<AuthorDto> CreateAuthor([FromBody]AuthorAddDto author)
        {
            var authorEntity = mapper.Map<Author>(author);
            var createdAuthor = authorRepository.CreateAuthor(authorEntity);
            var result = mapper.Map<AuthorDto>(createdAuthor);

            return CreatedAtRoute(nameof(GetAuthor), new { id = result.Id }, result);
        }
    }
}