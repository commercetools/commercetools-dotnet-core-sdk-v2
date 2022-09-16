using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingImagesMeta))]
    [Obsolete]
    public partial interface IMissingImagesMeta
    {
        [ObsoleteAttribute("This property is obsolete", false)]
        IMissingImagesProductLevel ProductLevel { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        IMissingImagesVariantLevel VariantLevel { get; set; }

        long Threshold { get; set; }

    }
}
