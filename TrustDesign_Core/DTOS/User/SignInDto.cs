﻿namespace TrustDesign_Core.DTOS.User
{
    public class SignInDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string UserPictuer { get; set; }
    }
}