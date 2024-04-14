﻿namespace SmallBasket.API.Model
{
    public class Users_RM
    {
        public Guid? UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
    }

    public class Login_RM
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
