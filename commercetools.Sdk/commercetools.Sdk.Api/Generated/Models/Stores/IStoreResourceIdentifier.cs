using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Api.Models.Stores.StoreResourceIdentifier))]
    public partial interface IStoreResourceIdentifier : IResourceIdentifier
    {
    }
}
