using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using web_api.Contracts;
using web_api.Model;

namespace web_api.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        public ShoppingItem Add(ShoppingItem newItem) //post
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShoppingItem> GetAllItems() //get
        {
            throw new NotImplementedException();
        }

        public ShoppingItem GetById(Guid id) //get
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id) //delete
        {
            throw new NotImplementedException();
        }
    }
}
