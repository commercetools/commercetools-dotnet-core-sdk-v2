using System;
using System.Collections.Generic;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class MissingImagesPagedQueryResult : IMissingImagesPagedQueryResult
    {
        public long Count { get; set; }

        public long Total { get; set; }

        public long Offset { get; set; }

        public List<IMissingImages> Results { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        public IMissingImagesMeta Meta { get; set; }
    }
}
