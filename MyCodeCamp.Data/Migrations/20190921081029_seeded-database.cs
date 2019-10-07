using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCodeCamp.Data.Migrations
{
    public partial class seededdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address1", "Address2", "Address3", "CityTown", "Country", "DateCreated", "DateUpdated", "PostalCode", "RowVersion", "StateProvince" },
                values: new object[] { 1L, "123 Main Street", null, null, "Atlanta", "USA", new DateTime(2019, 9, 21, 9, 10, 29, 299, DateTimeKind.Local), new DateTime(2019, 9, 21, 9, 10, 29, 301, DateTimeKind.Local), "30303", null, "GA" });

            migrationBuilder.InsertData(
                table: "Camps",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "EventDate", "Length", "LocationId", "Moniker", "Name", "RowVersion" },
                values: new object[] { 1L, new DateTime(2019, 9, 21, 9, 10, 29, 302, DateTimeKind.Local), new DateTime(2019, 9, 21, 9, 10, 29, 302, DateTimeKind.Local), "This is the first code camp", new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), 1, 1L, "ATL2016", "Your First Code Camp", null });

            migrationBuilder.InsertData(
                table: "Speakers",
                columns: new[] { "Id", "Bio", "CampId", "CompanyName", "DateCreated", "DateUpdated", "GitHubName", "HeadShotUrl", "Name", "PhoneNumber", "RowVersion", "TwitterName", "UserId", "WebsiteUrl" },
                values: new object[] { 1L, "I'm a speaker", 1L, "Wilder Minds LLC", new DateTime(2019, 9, 21, 9, 10, 29, 303, DateTimeKind.Local), new DateTime(2019, 9, 21, 9, 10, 29, 303, DateTimeKind.Local), "shawnwildermuth", "http://wilderminds.com/images/minds/shawnwildermuth.jpg", "Shawn Wildermuth", "555-1212", null, "shawnwildermuth", null, "http://wildermuth.com" });

            migrationBuilder.InsertData(
                table: "Speakers",
                columns: new[] { "Id", "Bio", "CampId", "CompanyName", "DateCreated", "DateUpdated", "GitHubName", "HeadShotUrl", "Name", "PhoneNumber", "RowVersion", "TwitterName", "UserId", "WebsiteUrl" },
                values: new object[] { 2L, "I'm a speaker", 1L, "Wilder Minds LLC", new DateTime(2019, 9, 21, 9, 10, 29, 303, DateTimeKind.Local), new DateTime(2019, 9, 21, 9, 10, 29, 303, DateTimeKind.Local), "resawildermuth", "http://wilderminds.com/images/minds/resawildermuth.jpg", "Resa Wildermuth", "555-1212", null, "resawildermuth", null, "http://wildermuth.com" });

            migrationBuilder.InsertData(
                table: "Talks",
                columns: new[] { "Id", "Abstract", "Category", "DateCreated", "DateUpdated", "Level", "Prerequisites", "Room", "RowVersion", "SpeakerId", "StartingTime", "Title" },
                values: new object[] { 1L, "How to do ASP.NET Core", "Web Development", new DateTime(2019, 9, 21, 9, 10, 29, 309, DateTimeKind.Local), new DateTime(2019, 9, 21, 9, 10, 29, 309, DateTimeKind.Local), "100", "C# Experience", "245", null, 1L, new DateTime(2019, 9, 21, 14, 30, 0, 0, DateTimeKind.Unspecified), "How to do ASP.NET Core" });

            migrationBuilder.InsertData(
                table: "Talks",
                columns: new[] { "Id", "Abstract", "Category", "DateCreated", "DateUpdated", "Level", "Prerequisites", "Room", "RowVersion", "SpeakerId", "StartingTime", "Title" },
                values: new object[] { 2L, "How to do Bootstrap 4", "Web Development", new DateTime(2019, 9, 21, 9, 10, 29, 309, DateTimeKind.Local), new DateTime(2019, 9, 21, 9, 10, 29, 309, DateTimeKind.Local), "100", "CSS Experience", "246", null, 1L, new DateTime(2019, 9, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), "How to do Bootstrap 4" });

            migrationBuilder.InsertData(
                table: "Talks",
                columns: new[] { "Id", "Abstract", "Category", "DateCreated", "DateUpdated", "Level", "Prerequisites", "Room", "RowVersion", "SpeakerId", "StartingTime", "Title" },
                values: new object[] { 3L, "Managing a Consulting Business", "Soft Skills", new DateTime(2019, 9, 21, 9, 10, 29, 309, DateTimeKind.Local), new DateTime(2019, 9, 21, 9, 10, 29, 309, DateTimeKind.Local), "100", null, "230", null, 2L, new DateTime(2019, 9, 21, 10, 30, 0, 0, DateTimeKind.Unspecified), "Managing a Consulting Business" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Talks",
                keyColumns: new[] { "Id", "RowVersion" },
                keyValues: new object[] { 1L, null });

            migrationBuilder.DeleteData(
                table: "Talks",
                keyColumns: new[] { "Id", "RowVersion" },
                keyValues: new object[] { 2L, null });

            migrationBuilder.DeleteData(
                table: "Talks",
                keyColumns: new[] { "Id", "RowVersion" },
                keyValues: new object[] { 3L, null });

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumns: new[] { "Id", "RowVersion" },
                keyValues: new object[] { 1L, null });

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumns: new[] { "Id", "RowVersion" },
                keyValues: new object[] { 2L, null });

            migrationBuilder.DeleteData(
                table: "Camps",
                keyColumns: new[] { "Id", "RowVersion" },
                keyValues: new object[] { 1L, null });

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumns: new[] { "Id", "RowVersion" },
                keyValues: new object[] { 1L, null });
        }
    }
}
