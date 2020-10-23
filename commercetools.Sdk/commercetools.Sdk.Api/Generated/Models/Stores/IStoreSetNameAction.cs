using commercetools.Api.Models.Common;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Api.Models.Stores.StoreSetNameAction))]
    public interface IStoreSetNameAction : IStoreUpdateAction
    {
        ILocalizedString Name { get; set;}
    }
}
