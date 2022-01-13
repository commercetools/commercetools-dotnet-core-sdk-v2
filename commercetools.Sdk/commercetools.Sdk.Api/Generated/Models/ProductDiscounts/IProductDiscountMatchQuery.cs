using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountMatchQuery))]
    public partial interface IProductDiscountMatchQuery
    {
        string ProductId { get; set; }

        int VariantId { get; set; }

        bool Staged { get; set; }

        IQueryPrice Price { get; set; }
    }
}
