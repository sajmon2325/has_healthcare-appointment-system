using Microsoft.EntityFrameworkCore;

namespace Healthcare_Appointment_System.Db;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
}