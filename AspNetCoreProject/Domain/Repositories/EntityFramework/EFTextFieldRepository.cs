using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreProject.Domain.Entities;
using AspNetCoreProject.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreProject.Domain.Repositories.EntityFramework
{
    public class EFTextFieldRepository : ITextFieldsRepository
    {
        private readonly AppDbContext context;
        public EFTextFieldRepository(AppDbContext context) => this.context = context;
        public void DeleteTextField(Guid id)
        {
            context.TextFields.Remove(new TextField() { Id = id });
            context.SaveChanges();
        }

        public TextField GetTextFieldByCodeWord(string codeWord)
        {
            return context.TextFields.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        public TextField GetTextFieldById(Guid id)
        {
            return context.TextFields.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<TextField> GetTextFields()
        {
            return context.TextFields;
        }

        public void SaveTextField(TextField entity)
        {
            if (entity.Id == default) //TODO : possible mistake | check later
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
