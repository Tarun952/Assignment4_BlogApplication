using System.ComponentModel.DataAnnotations;

namespace Assignment4_BlogApp.Models
{
    public class UserData
    {
        [Key]
        public int Id { get; set; }
        public string title { get; set; }
        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
