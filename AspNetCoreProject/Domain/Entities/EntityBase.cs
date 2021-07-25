using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreProject.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Название")]
        public virtual string Title { get; set; }
        [Display(Name = "Краткое описание")]
        public virtual string Subtitle { get; set; }
        [Display(Name = "Описание")]
        public virtual string Text { get; set; }
        public virtual string TitleImagePath { get; set; }
        [Display(Name = "Seo Title")]
        public string MetaTitle { get; set; }
        [Display(Name = "Seo Description")]
        public string MetaDescription { get; set; }
        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }


    }
}
