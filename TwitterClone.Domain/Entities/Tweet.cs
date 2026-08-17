using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity
    {
        public Guid AuthorId { get; }

        public string Content { get; }

        public Tweet(Guid authorId, string content) : base(new Guid())
        {
            AuthorId = authorId;
            Content = content;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, AuthorId: {AuthorId}, Content: {Content}";
        }
    }
}


