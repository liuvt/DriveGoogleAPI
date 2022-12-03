using System;
using System.Collections.Generic;

namespace AugCenterModel.Entities
{
    public partial class User
    {
        public int UserId { get; set; }
        public string? UserEmail { get; set; }
        public string? UserPassword { get; set; }
        public string? UserFirstName { get; set; }
        public string? UserLastName { get; set; }
        public string? UserCity { get; set; }
        public string? UserState { get; set; }
        public string? UserZip { get; set; }
        public bool? UserEmailVerified { get; set; }
        public DateTime? UserRegistrationDate { get; set; }
        public string? UserVerificationCode { get; set; }
        public string? UserIp { get; set; }
        public string? UserPhone { get; set; }
        public string? UserFax { get; set; }
        public string? UserCountry { get; set; }
        public string? UserAddress { get; set; }
        public string? UserAddress2 { get; set; }
    }
}
