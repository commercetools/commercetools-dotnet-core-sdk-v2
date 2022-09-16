using commercetools.Sdk.MLApi.Models.Common;
using System;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class MissingImages : IMissingImages
    {
        public IProductReference Product { get; set; }

        public long VariantId { get; set; }

        public long ImageCount { get; set; }
    }
}
