using System.ComponentModel.DataAnnotations;

namespace Iidioma_NetCore.ViewModel
{
    public class IdiomaDataAnotationVM
    {
        [Required(ErrorMessage = "The Email field is required.")]
        [Display(Name = "Name")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "The Idade field is required.")]
        [Display(Name = "Age")]
        public int Idade { get; set; }
    }
}