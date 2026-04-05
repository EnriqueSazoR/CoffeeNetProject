using System.ComponentModel.DataAnnotations;

namespace BackendCoffeeNet.Dto.RegistroDTO;

    public class RegistroDTO
    {
        [Required, MaxLength(50),
        RegularExpression(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ'-]+$",
        ErrorMessage ="El nombre debe tener una sola palabra sin espacios, números o caracteres especiales.")]
        public string Nombre { get; set; }

        [Required,MaxLength(50),
        RegularExpression(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ'-]+$",
        ErrorMessage = "El apellido debe tener una sola palabra sin espacios, números o caracteres especiales.")]
        public string Apellido { get; set; }

        [Required, EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
        public string Email { get; set; }

        [Required, MinLength(8), RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$",
        ErrorMessage = "La contraseña debe tener al menos 8 caracteres, incluyendo una letra mayúscula, una letra minúscula y un número.")]
        public string Password { get; set; }

        [Required, Phone]
        public string Telefono { get; set; }
    }    

