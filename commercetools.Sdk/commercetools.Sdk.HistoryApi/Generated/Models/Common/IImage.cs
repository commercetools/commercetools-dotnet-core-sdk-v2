using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.Image))]
    public partial interface IImage
    {
        string Url { get; set; }

        IImageDimensions Dimensions { get; set; }

        string Label { get; set; }

    }
}
