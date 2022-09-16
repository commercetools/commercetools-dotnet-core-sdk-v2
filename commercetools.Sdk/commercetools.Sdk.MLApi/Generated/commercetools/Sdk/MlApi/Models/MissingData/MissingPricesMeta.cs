using System;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class MissingPricesMeta : IMissingPricesMeta
    {
        [ObsoleteAttribute("This property is obsolete", false)]
        public IMissingPricesProductLevel ProductLevel { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        public IMissingPricesVariantLevel VariantLevel { get; set; }
    }
}
