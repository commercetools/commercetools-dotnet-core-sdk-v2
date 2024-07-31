

namespace commercetools.Sdk.Api.Models.Common
{

    public partial class AssetSource : IAssetSource
    {
        public string Uri { get; set; }

        public string Key { get; set; }

        public IAssetDimensions Dimensions { get; set; }

        public string ContentType { get; set; }
    }
}
