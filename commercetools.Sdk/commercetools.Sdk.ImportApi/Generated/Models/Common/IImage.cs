using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.Image))]
    public partial interface IImage
    {
        string Url { get; set; }

        IAssetDimensions Dimensions { get; set; }

        string Label { get; set; }

    }
}
