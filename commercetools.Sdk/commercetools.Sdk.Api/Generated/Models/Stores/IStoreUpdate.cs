using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Api.Models.Stores.StoreUpdate))]
    public interface IStoreUpdate 
    {
        long Version { get; set;}
        
        List<IStoreUpdateAction> Actions { get; set;}
    }
}
