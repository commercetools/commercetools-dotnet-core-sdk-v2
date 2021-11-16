using commercetools.Api.Models.Stores;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Api.Models.Stores.StoreSetCustomTypeAction))]
    public partial interface IStoreSetCustomTypeAction : IStoreUpdateAction
    {
        ITypeResourceIdentifier Type { get; set;}
        
        Object Fields { get; set;}
    }
}
