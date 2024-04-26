using Microsoft.AspNetCore.Identity;

namespace CareTrackPlus.Api.Models.Admin
{
    public class RegisterEmployee
    {
        public int Id { get; set; }
        public Guid EmployeeId { get; set; } = Guid.NewGuid();
        public string? DefaultUserName { get; set; }
        public string? DefaultPassword { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
    }
}
