using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingPricesMeta))]
    public partial interface IMissingPricesMeta
    {
        [ObsoleteAttribute("This property is obsolete", false)]
        IMissingPricesProductLevel ProductLevel { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        IMissingPricesVariantLevel VariantLevel { get; set; }

    }
}
