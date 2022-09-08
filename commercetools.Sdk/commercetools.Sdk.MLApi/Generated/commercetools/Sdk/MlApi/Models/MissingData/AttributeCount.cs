using System;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class AttributeCount : IAttributeCount
    {
        public int ProductTypeAttributes { get; set; }

        public int VariantAttributes { get; set; }

        public int MissingAttributeValues { get; set; }
    }
}
