using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ispat.DbContexts.Models
{
    public partial class Credential
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool IsBlock { get; set; }
    }
}
