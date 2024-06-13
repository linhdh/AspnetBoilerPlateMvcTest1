using System.ComponentModel.DataAnnotations;

namespace AspnetBoilerPlateMvcTest1.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}