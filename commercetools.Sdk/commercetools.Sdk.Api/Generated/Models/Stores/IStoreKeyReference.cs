using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Api.Models.Stores.StoreKeyReference))]
    public partial interface IStoreKeyReference : IKeyReference
    {
    }
}
