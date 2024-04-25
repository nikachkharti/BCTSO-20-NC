using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HotelProject.Models.Dtos
{
    public class UserLoginDto
    {
        [Required]
        [DisplayName("ელ-ფოსტა")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DisplayName("პაროლი")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [DisplayName("დამახსოვრება")]
        public bool RememberMe { get; set; }
    }
}
