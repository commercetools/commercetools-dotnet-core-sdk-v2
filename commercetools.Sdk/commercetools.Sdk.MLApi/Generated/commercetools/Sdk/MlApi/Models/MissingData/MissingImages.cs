using commercetools.Sdk.MLApi.Models.Common;


namespace commercetools.Sdk.MLApi.Models.MissingData
{

    public partial class MissingImages : IMissingImages
    {
        public IProductReference Product { get; set; }

        public long VariantId { get; set; }

        public long ImageCount { get; set; }
    }
}
