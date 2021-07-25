using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreProject.Domain.Entities;

namespace AspNetCoreProject.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(Guid id);
        /*TextField GetTextFieldByCodeWord(string codeWord);*/
        void SaveServiceItem(ServiceItem  entity);
        void DeleteServiceItem(Guid id);
    }
}
