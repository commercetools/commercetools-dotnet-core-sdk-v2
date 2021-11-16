using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Api.Models.Stores.StoreSetCustomFieldAction))]
    public partial interface IStoreSetCustomFieldAction : IStoreUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
