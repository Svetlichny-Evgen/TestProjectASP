using System.ComponentModel.DataAnnotations;

namespace TestProjectASP.Models
{
    public class Contact
    {
        [Display(Name ="Введите имя")]
        [Required(ErrorMessage ="Вам нужно ввести имя")]
        public string Name { get; set; }


        [Display(Name = "Введите фамилию")]
        [Required(ErrorMessage = "Вам нужно ввести фамилию")]
        public string Surname { get; set; }


        [Display(Name = "Введите ваш возраст")]
        [Required(ErrorMessage = "Вам нужно ввести ваш возраст")]
        public int Age { get; set; }


        [Display(Name = "Введите ваш аддрес эл.почты")]
        [Required(ErrorMessage = "Вам нужно ввести ваш аддрес эл.почты")]
        public string Email { get; set; }


        [Display(Name = "Введите сообщение, которое вы хотите отправить")]
        [StringLength(30, ErrorMessage ="Текст не менее 30 символов")]
        [Required(ErrorMessage = "Вам нужно ввести сообщение, которое вы хотите отправить")]
        public string Message { get; set; }
    }
}
