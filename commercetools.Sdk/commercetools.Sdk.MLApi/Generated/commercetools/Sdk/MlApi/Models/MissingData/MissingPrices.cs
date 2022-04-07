using commercetools.Sdk.MLApi.Models.Common;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    public partial class MissingPrices : IMissingPrices
    {
        public IProductReference Product { get; set; }

        public long VariantId { get; set; }
    }
}
