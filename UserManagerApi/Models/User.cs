using System.ComponentModel.DataAnnotations;

namespace UserManagerApi.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il nome è obbligatorio.")]
        [StringLength(50, ErrorMessage = "Il nome non può superare i 50 caratteri.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "L'email è obbligatoria.")]
        [EmailAddress(ErrorMessage = "Inserisci un indirizzo email valido.")]
        public string Email { get; set; }

        [Range(18, 120, ErrorMessage = "L'età deve essere compresa tra 18 e 120 anni.")]
        public int Age { get; set; }
    }
}
