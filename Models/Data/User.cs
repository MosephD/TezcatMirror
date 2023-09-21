using System.ComponentModel.DataAnnotations;


namespace Tescat1.Models.Data
{
    public class User
    {
        [Required]
        public int ID_USER { get; set; }

        [Required]
        public string? NAME { get; set; } = default!;

        public string? DEPT { get; set; } = default!;

        //[Required]
        public string? AREA { get; set; } = default!;

        public string? OFFICE { get; set; } = default!;

        //[Required]
        public string? POSITION { get; set; } = default!;

        //[Required]
        public DateTime? ENTRY_DATE { get; set; }

        public DateTime? LAST_WORKING_DATE { get; set; }

        public int? TEL { get; set; }

        public int? TEL_KEY { get; set; }

        public int? CEL { get; set; }

        public bool? WEB_PRIVILEGES { get; set; }

        //[Required]
        public DateTime? LAST_MODIF { get; set; }

        public List<UserEmails> Email { get; set; } = new List<UserEmails>();

        public string? IMAGE_NAME { get; set; }

        [Timestamp]
        public byte[]? Timestamp { get; set; }
    }

    public class UserEmails
    {
        public int Id { get; set; }
        public string UserEmail { get; set; } = default!;
        public int UserId { get; set; }
        public User User { get; set; } = default!;

    }
}
