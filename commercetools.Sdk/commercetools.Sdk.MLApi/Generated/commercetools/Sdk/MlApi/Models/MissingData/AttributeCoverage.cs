using System;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class AttributeCoverage : IAttributeCoverage
    {
        public decimal Names { get; set; }

        public decimal Values { get; set; }
    }
}
