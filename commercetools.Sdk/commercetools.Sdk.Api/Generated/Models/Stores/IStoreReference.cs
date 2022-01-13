using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Api.Models.Stores.StoreReference))]
    public partial interface IStoreReference : IReference
    {
        IStore Obj { get; set; }
    }
}
