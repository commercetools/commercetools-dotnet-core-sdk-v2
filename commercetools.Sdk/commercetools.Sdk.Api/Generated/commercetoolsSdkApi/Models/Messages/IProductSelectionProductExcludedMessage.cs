using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionProductExcludedMessage))]
    public partial interface IProductSelectionProductExcludedMessage : IMessage
    {
        IProductReference Product { get; set; }

        IProductVariantExclusion VariantExclusion { get; set; }

    }
}
