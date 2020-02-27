﻿using Ascentic.BookStore.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ascentic.BookStore.Model.DTO
{
    public class AuthorDTO: IBaseDTO
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string Birthplace { get; set; }
        public string Facts { get; set; }

        public List<BookAuthorDTO> BookAuthor { get; set; }
        public string PhotoURL { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
