using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Dodaj nazwe oferty")]
        [Display(Name = "Nazwa oferty")]
        public override string Title { get; set; }

        [Display(Name = "Krotki opis oferty")]
        public override string Subtitle { get; set; }

        [Display(Name = "Pelny opis oferty")]
        public override string Text { get; set; }
    }
}
