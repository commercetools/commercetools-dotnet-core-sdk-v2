using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionVariantSelectionChangedMessage))]
    public partial interface IProductSelectionVariantSelectionChangedMessage : IMessage
    {
        IProductReference Product { get; set; }

        IProductVariantSelection OldVariantSelection { get; set; }

        IProductVariantSelection NewVariantSelection { get; set; }

    }
}
