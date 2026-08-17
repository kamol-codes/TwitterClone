using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; }
        public DateTimeOffset CreatedAt { get; }
        public DateTimeOffset? ModifiedAt { get; }
        public Guid CreatedBy { get; }
        public Guid? ModifiedBy { get; }

        public BaseEntity(Guid id)
        {
            Id = id;
            CreatedAt = DateTimeOffset.Now;
        }
        public virtual string DescribeRecord()
        {
            return $"BaseEntity: Id: {Id}, CreatedAt: {CreatedAt}, ModifiedAt: {ModifiedAt}, CreatedBy: {CreatedBy}, ModifiedBy: {ModifiedBy}";
        }

    }
}
