using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionProductExcludedMessagePayload))]
    public partial interface IProductSelectionProductExcludedMessagePayload : IMessagePayload
    {
        IProductReference Product { get; set; }

        IProductVariantExclusion VariantExclusion { get; set; }

    }
}
