using System.ComponentModel.DataAnnotations;

namespace TallerCodeChallenge.Models
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string? Name { get; set; }
    }
}
