using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Api.Models.Stores.StoreSetLanguagesAction))]
    public partial interface IStoreSetLanguagesAction : IStoreUpdateAction
    {
        List<string> Languages { get; set;}
    }
}
