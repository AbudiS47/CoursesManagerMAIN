namespace CourseManagementMVC.Data;

using Microsoft.EntityFrameworkCore;

{
    public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<CourseManagementMVC.Models.Course> Courses { get; set; }
}
