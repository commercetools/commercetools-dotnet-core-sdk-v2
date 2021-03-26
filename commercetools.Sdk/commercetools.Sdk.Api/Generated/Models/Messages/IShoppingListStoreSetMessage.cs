using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ShoppingListStoreSetMessage))]
    public partial interface IShoppingListStoreSetMessage : IMessage
    {
        IStoreKeyReference Store { get; set;}
    }
}