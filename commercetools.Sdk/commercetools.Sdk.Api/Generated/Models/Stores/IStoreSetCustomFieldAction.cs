using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetCustomFieldAction))]
    public partial interface IStoreSetCustomFieldAction : IStoreUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
