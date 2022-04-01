using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.AssetDimensions))]
    public partial interface IAssetDimensions
    {
        int W { get; set; }

        int H { get; set; }
    }
}
