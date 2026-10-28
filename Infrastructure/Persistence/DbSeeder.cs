using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Persistence;

public static class DbSeeder
{
    
    private static readonly Guid JohnDoeId = Guid.Parse("11111111-1111-1111-1111-111111111111");
    private static readonly Guid JaneSmithId = Guid.Parse("22222222-2222-2222-2222-222222222222");
    private static readonly Guid Cs101Id = Guid.Parse("33333333-3333-3333-3333-333333333333");
    private static readonly Guid Cs201Id = Guid.Parse("44444444-4444-4444-4444-444444444444");
    private static readonly Guid Cs301Id = Guid.Parse("55555555-5555-5555-5555-555555555555");

    public static async Task SeedAsync(IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        var logger = scope.ServiceProvider.GetRequiredService<ILogger<AppDbContext>>();

        try
        {
           
            await context.Database.MigrateAsync();

           
            if (await context.Students.AnyAsync() || await context.Courses.AnyAsync())
            {
                return; 
            }

           
            var students = new List<Student>
            {
                new Student { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com" },
                new Student { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com" }
            };
            await context.Students.AddRangeAsync(students);

            
            var courses = new List<Course>
            {
                new Course { Id = 1, Title = "Introduction to Computer Science", Code = "CS101" },
                new Course { Id = 2, Title = "Data Structures and Algorithms", Code = "CS201" },
                new Course { Id = 3, Title = "Database Management Systems", Code = "CS301" }
            };
            await context.Courses.AddRangeAsync(courses);

            await context.SaveChangesAsync();
            logger.LogInformation("Database seeded successfully.");
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "An error occurred while seeding the database.");
        }
    }
}