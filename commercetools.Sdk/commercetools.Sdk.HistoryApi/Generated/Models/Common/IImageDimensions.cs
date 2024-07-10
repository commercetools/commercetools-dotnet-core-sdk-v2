using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ImageDimensions))]
    public partial interface IImageDimensions
    {
        int W { get; set; }

        int H { get; set; }

    }
}
