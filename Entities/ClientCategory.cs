using System.ComponentModel.DataAnnotations;

namespace LetsMarket.Entities
{
    public enum ClientCategory
    {
        [Display(Name = "Bronze")]
        Bronze,

        [Display(Name = "Prata")]
        Silver,

        [Display(Name = "Ouro")]
        Gold

    }

}