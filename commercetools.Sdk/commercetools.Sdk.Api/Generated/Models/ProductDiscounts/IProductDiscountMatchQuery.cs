using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountMatchQuery))]
    public partial interface IProductDiscountMatchQuery
    {
        string ProductId { get; set; }

        int VariantId { get; set; }

        bool Staged { get; set; }

        IQueryPrice Price { get; set; }

    }
}
