using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LuanTest.Models
{
    public class Student
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        [StringLength(80, ErrorMessage = "O nome deve ter no m�ximo 80 caracteres")]
        [MinLength(5, ErrorMessage = "O nome deve conter no m�nimo 5 caracteres")]
        [DisplayName("Nome Completo")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o E-mail")]
        [EmailAddress(ErrorMessage = "E-mail inv�lido")]
        [DisplayName("E-mail")]

        public string Email { get; set; } = string.Empty;

        

    }
}
