using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.Models.Dtos
{
    public class UserRegistrationDto
    {
        [Required(ErrorMessage = "სავალდებულო ველი")]
        [DisplayName("სახელი")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "სავალდებულო ველი")]
        [DisplayName("გვარი")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "სავალდებულო ველი")]
        [DisplayName("ელ-ფოსტა")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "სავალდებულო ველი")]
        [DisplayName("პაროლი")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "სავალდებულო ველი")]
        [DataType(DataType.Password)]
        [DisplayName("გაიმეორეთ პაროლი")]
        [Compare("Password", ErrorMessage = "პირველადი პაროლი არ ემთხვევა გამეორებულ პაროლს")]
        public string ConfirmPassword { get; set; }
    }
}
