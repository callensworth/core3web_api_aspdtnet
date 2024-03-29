﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api.Model;


namespace web_api.Contracts
{
    public interface IShoppingCartService
    {
        IEnumerable<ShoppingItem> GetAllItems();
        ShoppingItem Add(ShoppingItem newItem);
        ShoppingItem GetById(Guid id);
        void Remove(Guid id);
    }
}
