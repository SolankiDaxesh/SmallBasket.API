using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace SmallBasket.API.Entities.User
{
    [Keyless]
    public class Users 
    {
        public Guid UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
        public string MobileNumber { get; set; }

        public string Password { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDelete { get; set; } = false;
        public DateTime CreatedDate { get; set; }

    }
}
