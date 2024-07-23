using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductTailoringDeletedMessagePayload))]
    public partial interface IProductTailoringDeletedMessagePayload : IMessagePayload
    {
        IStoreKeyReference Store { get; set; }

        string ProductKey { get; set; }

        IProductReference Product { get; set; }

    }
}
