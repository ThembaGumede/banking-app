using System.ComponentModel.DataAnnotations;
namespace BankingApp.DTOs
{
    public class LoginRequestDto
    {
        [Required]
        [EmailAddress] //built-in validation attribute to check if the string is in email format
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    
}