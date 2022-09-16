using System;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class MissingAttributesDetails : IMissingAttributesDetails
    {
        public int Total { get; set; }

        public int MissingAttributeNames { get; set; }

        public int MissingAttributeValues { get; set; }
    }
}
