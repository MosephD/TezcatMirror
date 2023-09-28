//using System;
//using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

namespace Tescat1.Models.Data
{
    public partial class UserWithCredentials
    {
        public User? User { get; set; }
        public UserCredentials? Credentials { get; set; }
    }
}