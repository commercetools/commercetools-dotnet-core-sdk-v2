using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Common.Image))]
    public partial interface IImage
    {
        string Url { get; set; }

        IAssetDimensions Dimensions { get; set; }

        string Label { get; set; }
    }
}
