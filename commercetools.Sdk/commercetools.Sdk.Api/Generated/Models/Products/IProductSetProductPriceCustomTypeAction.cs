using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetProductPriceCustomTypeAction))]
    public partial interface IProductSetProductPriceCustomTypeAction : IProductUpdateAction
    {
        string PriceId { get; set; }

        bool? Staged { get; set; }

        ITypeResourceIdentifier Type { get; set; }

        IFieldContainer Fields { get; set; }

    }
}
