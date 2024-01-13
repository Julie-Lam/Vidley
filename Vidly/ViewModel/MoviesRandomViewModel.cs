﻿using Vidly.Models;

namespace Vidly.ViewModel
{
    public class MoviesRandomViewModel
    {
        public required Movie Movie { get; set; }

        public required List<Customer> Customers { get; set; }
    }
}
