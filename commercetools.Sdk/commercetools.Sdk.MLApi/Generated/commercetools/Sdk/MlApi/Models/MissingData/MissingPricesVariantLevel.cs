using System;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class MissingPricesVariantLevel : IMissingPricesVariantLevel
    {
        public long Total { get; set; }

        public long MissingPrices { get; set; }
    }
}
