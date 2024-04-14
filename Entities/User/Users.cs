using Microsoft.EntityFrameworkCore;

namespace SmallBasket.API.Entities.User
{
    [PrimaryKey("UserId")]
    public class Users
    {

        public Guid UserId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
        public string MobileNumber { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public bool IsDelete { get; set; } = false;
        public DateTime CreatedDate { get; set; }

    }
}
