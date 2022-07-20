using Dapper.Contrib.Extensions;

namespace Blog_Dapper.Models
{
    [Table("[UserRole]")]
    public class UserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
