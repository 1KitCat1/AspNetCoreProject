using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreProject.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Введите название услуги")]
        [Display(Name = "Название услуги")]
        public override string Title { get; set; } = "Название услуги";
        [Display(Name = "Краткое описание услуги")]
        public override string Subtitle { get; set; } = "Краткое описание";

        [Display(Name = "Описание услуги")]
        public override string Text { get; set; } = "Описание услуги";

    }
}
