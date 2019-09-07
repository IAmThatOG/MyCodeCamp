using System;

namespace MyCodeCamp.Data.Entities
{
    public class CampUser : BaseEntity
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
    }
}