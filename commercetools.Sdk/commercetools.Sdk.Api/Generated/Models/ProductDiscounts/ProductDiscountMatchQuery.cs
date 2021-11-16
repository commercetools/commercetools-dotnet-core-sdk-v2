using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountMatchQuery : IProductDiscountMatchQuery
    {
        public string ProductId { get; set; }

        public int VariantId { get; set; }

        public bool Staged { get; set; }

        public IQueryPrice Price { get; set; }
    }
}
