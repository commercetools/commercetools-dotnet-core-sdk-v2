using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.ImageDimensions))]
    public partial interface IImageDimensions
    {
        int W { get; set; }

        int H { get; set; }
    }
}
