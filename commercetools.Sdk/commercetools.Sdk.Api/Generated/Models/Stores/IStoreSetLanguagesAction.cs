using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetLanguagesAction))]
    public partial interface IStoreSetLanguagesAction : IStoreUpdateAction
    {
        List<string> Languages { get; set; }

    }
}
