using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace MyCodeCamp.Data.Entities
{
    public class Talk : BaseEntity
    {    
        [Required]
        public string Title { get; set; }
        public string Abstract { get; set; }
        public string Category { get; set; }
        public string Level { get; set; }
        public string Prerequisites { get; set; }
        public DateTime StartingTime { get; set; } = DateTime.Now;
        public string Room { get; set; }
        public long SpeakerId { get; set; }

        public Speaker Speaker { get; set; }

    }
}