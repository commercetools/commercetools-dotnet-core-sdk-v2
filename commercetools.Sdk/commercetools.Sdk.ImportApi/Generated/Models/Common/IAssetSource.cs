using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.AssetSource))]
    public partial interface IAssetSource
    {
        string Uri { get; set; }

        string Key { get; set; }

        IAssetDimensions Dimensions { get; set; }

        string ContentType { get; set; }
    }
}
