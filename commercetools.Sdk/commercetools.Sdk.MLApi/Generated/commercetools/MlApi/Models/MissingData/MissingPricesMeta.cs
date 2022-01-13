namespace commercetools.MLApi.Models.MissingData
{
    public partial class MissingPricesMeta : IMissingPricesMeta
    {
        public IMissingPricesProductLevel ProductLevel { get; set; }

        public IMissingPricesVariantLevel VariantLevel { get; set; }
    }
}
