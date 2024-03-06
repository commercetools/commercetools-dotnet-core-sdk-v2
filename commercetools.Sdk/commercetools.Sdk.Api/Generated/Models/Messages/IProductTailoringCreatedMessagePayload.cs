using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductTailoringCreatedMessagePayload))]
    public partial interface IProductTailoringCreatedMessagePayload : IMessagePayload
    {
        string Key { get; set; }

        IStoreKeyReference Store { get; set; }

        string ProductKey { get; set; }

        IProductReference Product { get; set; }

        ILocalizedString Description { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Slug { get; set; }

        bool Published { get; set; }

    }
}
