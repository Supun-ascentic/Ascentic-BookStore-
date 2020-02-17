﻿using Ascentic.BookStore.Domain.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ascentic.BookStore.Domain.DTO
{
    public class RatingDTO : IBaseDTO
    {
        public int ID { get; set; }
        [Required]
        public double Rating { get; set; }

        [Required]
        public int BookId { get; set; }
    }
}
