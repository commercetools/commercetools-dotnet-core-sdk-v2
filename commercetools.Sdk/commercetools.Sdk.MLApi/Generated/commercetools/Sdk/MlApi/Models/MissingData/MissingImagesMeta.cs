namespace commercetools.Sdk.MLApi.Models.MissingData
{

    public partial class MissingImagesMeta : IMissingImagesMeta
    {
        public IMissingImagesProductLevel ProductLevel { get; set; }

        public IMissingImagesVariantLevel VariantLevel { get; set; }

        public long Threshold { get; set; }
    }
}
