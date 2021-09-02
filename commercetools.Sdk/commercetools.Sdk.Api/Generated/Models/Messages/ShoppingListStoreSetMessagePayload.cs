using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class ShoppingListStoreSetMessagePayload : IShoppingListStoreSetMessagePayload
    {
        public string Type { get; set; }

        public IStoreKeyReference Store { get; set; }
        public ShoppingListStoreSetMessagePayload()
        {
            this.Type = "ShoppingListStoreSet";
        }
    }
}
