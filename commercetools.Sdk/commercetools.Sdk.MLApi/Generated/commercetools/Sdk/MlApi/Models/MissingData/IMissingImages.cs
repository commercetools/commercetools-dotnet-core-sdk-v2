using commercetools.Sdk.MLApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingImages))]
    public partial interface IMissingImages
    {
        IProductReference Product { get; set; }

        long VariantId { get; set; }

        long ImageCount { get; set; }
    }
}
