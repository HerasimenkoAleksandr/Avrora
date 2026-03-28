using System.ComponentModel.DataAnnotations;

namespace Avrora.Models.Enums
{
    public enum CarTypeEnum
    {
        [Display(Name = "Легковий")]

        Sedan,

        [Display(Name = "Кросовер")]
        
        Crossover,

        [Display(Name = "Універсал")]
        
        Universal
    }
}
