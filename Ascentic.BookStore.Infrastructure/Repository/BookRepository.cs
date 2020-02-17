﻿namespace Ascentic.BookStore.Infrastructure.Repository
{
    using Ascentic.BookStore.Domain.Entity;
    using Ascentic.BookStore.Infrastructure.DbContext;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class BookRepository : GenericRepository<Book, BookStoreDbContext>
    {

     
        private readonly BookStoreDbContext context;
        public BookRepository(BookStoreDbContext context)
            : base(context)
        {
            this.context = context;
        }

        public async Task<List<Book>> GetBooksWithAllDetails()
        {
            return await this.context.Set<Book>()
                .Include(book=> book.BookAuthor)
                .ThenInclude(bookAuthor => bookAuthor.Author)
                .Include(book => book.Category)
                .Include(book => book.Ratings)
                .ToListAsync();
        } 
        // We can add new methods specific to the movie repository here in the future
    }
}

