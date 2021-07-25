using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreProject.Domain.Entities;
using AspNetCoreProject.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreProject.Domain.Repositories.EntityFramework
{
    public class EFServiceItemRepository : IServiceItemsRepository
    {
        private readonly AppDbContext context;
        public EFServiceItemRepository(AppDbContext context) => this.context = context;
        public void DeleteServiceItem(Guid id)
        {
            context.ServiceItems.Remove(new ServiceItem() { Id = id });
            context.SaveChanges();
        }


        public ServiceItem GetServiceItemById(Guid id)
        {
            return context.ServiceItems.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<ServiceItem> GetServiceItems()
        {
            return context.ServiceItems;
        }

        public void SaveServiceItem(ServiceItem entity)
        {
            if (entity.Id == default) //TODO : possible mistake | check later
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
