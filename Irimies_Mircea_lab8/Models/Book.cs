﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Irimies_Mircea_lab8.Models
{
    public class Book
    {
        [Display(Name = "Book Title")]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
    }
}

