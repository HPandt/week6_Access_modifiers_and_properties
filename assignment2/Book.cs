﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class Book
    {
 

        public string Title { get; }
        public string Author { get; }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        

    }
}