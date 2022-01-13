namespace commercetools.MLApi.Models.Common
{
    public partial class ProductVariant : IProductVariant
    {
        public IProductReference Product { get; set; }

        public bool Staged { get; set; }

        public int VariantId { get; set; }
    }
}
