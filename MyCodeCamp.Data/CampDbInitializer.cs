using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyCodeCamp.Data.Entities;

namespace MyCodeCamp.Data
{
    public static class CampDbInitializer
    {
        public static void SeedLocation(this ModelBuilder modelBuilder)
        {
            var location = new Location
            {
                Id = 1,
                Address1 = "123 Main Street",
                CityTown = "Atlanta",
                StateProvince = "GA",
                PostalCode = "30303",
                Country = "USA",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };
            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasData(location);
            });
        }
        public static void SeedTalks(this ModelBuilder modelBuilder)
        {
           var talks = new List<Talk>
            {
                new Talk
                {
                    Id = 1,
                    Title = "How to do ASP.NET Core",
                    Abstract = "How to do ASP.NET Core",
                    Category = "Web Development",
                    Level = "100",
                    Prerequisites = "C# Experience",
                    Room = "245",
                    StartingTime = DateTime.Parse("14:30"),
                    SpeakerId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new Talk
                {
                    Id = 2,
                    Title = "How to do Bootstrap 4",
                    Abstract = "How to do Bootstrap 4",
                    Category = "Web Development",
                    Level = "100",
                    Prerequisites = "CSS Experience",
                    Room = "246",
                    StartingTime = DateTime.Parse("13:00"),
                    SpeakerId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new Talk
                {
                    Id = 3,
                    Title = "Managing a Consulting Business",
                    Abstract = "Managing a Consulting Business",
                    Category = "Soft Skills",
                    Level = "100",
                    Room = "230",
                    StartingTime = DateTime.Parse("10:30"),
                    SpeakerId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                }
            };
            modelBuilder.Entity<Talk>(entity => {
                entity.HasData(talks.ToArray());
            });
        }
        public static void SeedSpeakers(this ModelBuilder modelBuilder)
        {
            // List<Talk> talks = CampDbInitializer._talks.FindAll(x => x.Id == 1 || x.Id == 2);
            var speakers = new List<Speaker>
            {
                new Speaker
                {
                    Id = 1,
                    Name = "Shawn Wildermuth",
                    Bio = "I'm a speaker",
                    CompanyName = "Wilder Minds LLC",
                    GitHubName = "shawnwildermuth",
                    TwitterName = "shawnwildermuth",
                    PhoneNumber = "555-1212",
                    HeadShotUrl = "http://wilderminds.com/images/minds/shawnwildermuth.jpg",
                    WebsiteUrl = "http://wildermuth.com",
                    CampId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new Speaker
                {
                    Id = 2,
                    Name = "Resa Wildermuth",
                    Bio = "I'm a speaker",
                    CompanyName = "Wilder Minds LLC",
                    GitHubName = "resawildermuth",
                    TwitterName = "resawildermuth",
                    PhoneNumber = "555-1212",
                    HeadShotUrl = "http://wilderminds.com/images/minds/resawildermuth.jpg",
                    WebsiteUrl = "http://wildermuth.com",
                    CampId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                }
            };
            modelBuilder.Entity<Speaker>(entity => {
                entity.HasData(speakers.ToArray()); 
            });
        }
        public static void SeedCamps(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Camp>(entity =>
                {
                    entity.HasData(
                        new Camp
                        {
                            Id = 1,
                            Name = "Your First Code Camp",
                            Moniker = "ATL2016",
                            EventDate = DateTime.Today.AddDays(45),
                            Length = 1,
                            Description = "This is the first code camp",
                            LocationId = 1,
                            DateCreated = DateTime.Now,
                            DateUpdated = DateTime.Now
                        }
                    );
                });
        }
    }
}