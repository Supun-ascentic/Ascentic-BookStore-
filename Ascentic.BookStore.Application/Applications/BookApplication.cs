﻿using Ascentic.BookStore.Application.Interfaces;
using Ascentic.BookStore.Model.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ascentic.BookStore.Domain.Interfaces;
using Ascentic.BookStore.Model.DTO;
using Ascentic.BookStore.Model.Entity;

namespace Ascentic.BookStore.Application.Applications
{
    public class BookApplication : BaseApplication<Book, BookDTO>,IBookApplication
    {
        private readonly IMapper mapper;
        private readonly IBookDomain bookDomain;

        public BookApplication(IBookDomain bookDomain, IMapper mapper)
            :base(bookDomain,mapper)
        {
            this.bookDomain = bookDomain;
            this.mapper = mapper;
        }

    }
}
