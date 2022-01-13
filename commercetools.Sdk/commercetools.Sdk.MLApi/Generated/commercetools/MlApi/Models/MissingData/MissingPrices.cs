using commercetools.MLApi.Models.Common;


namespace commercetools.MLApi.Models.MissingData
{
    public partial class MissingPrices : IMissingPrices
    {
        public IProductReference Product { get; set; }

        public long VariantId { get; set; }
    }
}
