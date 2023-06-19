using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionVariantSelectionChangedMessagePayload))]
    public partial interface IProductSelectionVariantSelectionChangedMessagePayload : IMessagePayload
    {
        IProductReference Product { get; set; }

        IProductVariantSelection OldVariantSelection { get; set; }

        IProductVariantSelection NewVariantSelection { get; set; }

    }
}
