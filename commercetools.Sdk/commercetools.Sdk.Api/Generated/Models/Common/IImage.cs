using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.Image))]
    public partial interface IImage
    {
        string Url { get; set; }

        IImageDimensions Dimensions { get; set; }

        string Label { get; set; }
    }
}
