using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {

        public Guid Id { get; }

        public Guid AuthorId { get; }

        public string Content { get; set; }
    }
}

 
