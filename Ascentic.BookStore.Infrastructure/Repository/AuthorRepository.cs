﻿namespace Ascentic.BookStore.Infrastructure.Repository
{
    using Ascentic.BookStore.Domain.Entity;
    using Ascentic.BookStore.Infrastructure.DbContext;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class AuthorRepository : GenericRepository<Author, BookStoreDbContext>
    {
        private readonly BookStoreDbContext context;
        public AuthorRepository(BookStoreDbContext context)
            : base(context)
        {
            this.context = context;
        }
        // We can add new methods specific to the movie repository here in the future


        public async Task<List<Author>> GetAuthorsWithBooks()
        {
            return await this.context.Set<Author>()
                .Include(author => author.BookAuthor)
                .ThenInclude(bookAuthor => bookAuthor.Book)
                .ToListAsync();
        }
    }
}

