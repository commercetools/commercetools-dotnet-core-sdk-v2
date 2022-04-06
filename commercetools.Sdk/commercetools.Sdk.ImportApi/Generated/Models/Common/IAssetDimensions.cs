using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.AssetDimensions))]
    public partial interface IAssetDimensions
    {
        int W { get; set; }

        int H { get; set; }
    }
}
