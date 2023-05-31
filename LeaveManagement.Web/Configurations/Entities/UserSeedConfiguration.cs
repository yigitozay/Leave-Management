using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        
            public void Configure(EntityTypeBuilder<Employee> builder)
            {
              var hasher = new PasswordHasher<Employee>();
                builder.HasData(
                    new Employee
                    {
                        Id = "d0cfcdff-acb8-424a-b498-f983d89e40c0",
                        Email = "admin@local.test",
                        NormalizedEmail = "ADMIN@LOCAL.TEST",
                        NormalizedUserName = "ADMIN@LOCAL.TEST",
                        UserName= "admin@local.test",
                        FirstName = "admin",
                        LastName = "test",
                        PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                        EmailConfirmed = true
                    } );
            }
        }
    
}