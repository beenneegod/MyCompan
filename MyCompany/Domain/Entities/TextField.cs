using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Nazwa strony (tytul)")]
        public override string Title { get; set; } = "Info";

        [Display(Name = "Zawartosc strony")]
        public override string Text { get; set; } = "Zawartosc jest edytowana przez administratora";
    }
}
