using System.Collections.Generic;
using System;
namespace MyCodeCamp.Data.Entities
{
    public class Camp : BaseEntity
    {
        public string Moniker { get; set; }
        public string Name { get; set; }
        public DateTime EventDate { get; set; } = DateTime.MinValue;
        public int Length { get; set; }
        public string Description { get; set; }
        public Location Location { get; set; }
        public ICollection<Speaker> Speakers { get; set; }

        public Camp()
        {
            Speakers = new List<Speaker>();
        }

    }
}