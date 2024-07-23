namespace commercetools.Sdk.ImportApi.Models.Common
{

    public partial class Image : IImage
    {
        public string Url { get; set; }

        public IAssetDimensions Dimensions { get; set; }

        public string Label { get; set; }
    }
}
