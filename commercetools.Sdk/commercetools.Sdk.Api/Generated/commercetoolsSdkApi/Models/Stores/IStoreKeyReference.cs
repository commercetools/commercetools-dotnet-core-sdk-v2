using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreKeyReference))]
    public partial interface IStoreKeyReference : IKeyReference
    {
        new string Key { get; set; }

    }
}
