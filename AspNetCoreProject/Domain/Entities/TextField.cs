using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreProject.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Название страницы")]
        public override string Title { get; set; } = "Заголовок";

        [Display(Name = "Содержание страницы")]
        public override string Text { get; set; } = "Текст записи";



    }
}
