using System;
using Microsoft.EntityFrameworkCore;
using SchoolLibrary;

public class SchoolDbContext : DbContext {
  public DbSet<Student> Students { get; set; }

  public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

  protected override void OnModelCreating(ModelBuilder builder) {
    base.OnModelCreating(builder);

    builder.Entity<Student>().HasData(
      new {
        StudentId = Guid.NewGuid().ToString(),
        FirstName = "Jim",
        LastName = "Potter",
        BCITID = "A00123448",
        MobileNo = "604-123-4567",
        Email = "jim@potter.com",
        City = "Chilliwack",
        Option = "Web & Mobile",
        Set = "S"
      }, new {
        StudentId = Guid.NewGuid().ToString(),
        FirstName = "Will",
        LastName = "Smith",
        BCITID = "A00816734",
        MobileNo = "604-111-1111",
        Email = "will@smith.com",
        City = "Capillano",
        Option = "Mechatronics",
        Set = "V"
      }, new {
        StudentId = Guid.NewGuid().ToString(),
        FirstName = "Tim",
        LastName = "James",
        BCITID = "A00648317",
        MobileNo = "604-222-2222",
        Email = "tim@james.com",
        City = "Victoria",
        Option = "Mechatronics",
        Set = "v"
      }, new {
        StudentId = Guid.NewGuid().ToString(),
        FirstName = "Sarah",
        LastName = "Parker",
        BCITID = "A00123451",
        MobileNo = "604-333-3333",
        Email = "sarah@parker.com",
        City = "Mission",
        Option = "Web & Mobile",
        Set = "S"
      }, new {
        StudentId = Guid.NewGuid().ToString(),
        FirstName = "Ricky",
        LastName = "Low",
        BCITID = "A00123452",
        MobileNo = "604-444-4444",
        Email = "ricky@low.com",
        City = "Vancouver",
        Option = "AI",
        Set = "F"
      }, new {
        StudentId = Guid.NewGuid().ToString(),
        FirstName = "Terry",
        LastName = "Crews",
        BCITID = "A00123453",
        MobileNo = "604-555-5555",
        Email = "terry@crews.com",
        City = "Burnaby",
        Option = "AI",
        Set = "F"
      }, new {
        StudentId = Guid.NewGuid().ToString(),
        FirstName = "Jerry",
        LastName = "Wither",
        BCITID = "A00123454",
        MobileNo = "604-666-6666",
        Email = "jerry@wither.com",
        City = "Los Angeles",
        Option = "Web & Mobile",
        Set = "S"
      }, new {
        StudentId = Guid.NewGuid().ToString(),
        FirstName = "Jones",
        LastName = "Potter",
        BCITID = "A00123455",
        MobileNo = "604-777-7777",
        Email = "jones@potter.com",
        City = "Langley",
        Option = "Web & Mobile",
        Set = "S"
      }, new {
        StudentId = Guid.NewGuid().ToString(),
        FirstName = "Lana",
        LastName = "DelRay",
        BCITID = "A00123456",
        MobileNo = "604-888-8888",
        Email = "Lana@DelRay.com",
        City = "Surrey",
        Option = "Tech Entrepeneur",
        Set = "G"
      }
    );
  }
}
