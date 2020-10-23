using commercetools.Api.Generated.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Stores
{
    public interface IStoreUpdate 
    {
        long Version { get; set;}
        
        List<IStoreUpdateAction> Actions { get; set;}
    }
}
