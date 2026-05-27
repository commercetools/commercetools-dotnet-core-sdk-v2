using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreReference))]
    public partial interface IStoreReference : IReference
    {
        new IReferenceTypeId TypeId { get; set; }

        IStore Obj { get; set; }

        new string Id { get; set; }

    }
}
