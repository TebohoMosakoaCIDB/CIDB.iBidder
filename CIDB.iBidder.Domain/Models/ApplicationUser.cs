using Microsoft.AspNetCore.Identity;

namespace CIDB.iBidder.Domain.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string CsdNumber { get; set; } = string.Empty;

        public string CrsNumber { get; set; } = string.Empty;

        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;
    }
}
