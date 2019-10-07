using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCodeCamp.Data.Entities
{
    public abstract class BaseEntity
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public byte[] RowVersion { get; set; }
    }
}