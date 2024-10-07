using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionProductAddedMessagePayload))]
    public partial interface IProductSelectionProductAddedMessagePayload : IMessagePayload
    {
        IProductReference Product { get; set; }

        IProductVariantSelection VariantSelection { get; set; }

    }
}
