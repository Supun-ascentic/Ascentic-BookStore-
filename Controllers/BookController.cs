﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ascentic_BookStore.Data.EFCore;
using Ascentic_BookStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ascentic_BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : BaseController<Book, EfCoreBookRepository>
    {

        private readonly EfCoreBookRepository repository;
        public BookController(EfCoreBookRepository repository)
            : base(repository)
        {
            this.repository = repository;
        }

        // GET: api/[controller]
        [Authorize]
        [HttpGet]
        [Route("get_books_with_all_Details")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksWithAllDetails()
        {
            return await this.repository.GetBooksWithAllDetails();
        }
    }
}