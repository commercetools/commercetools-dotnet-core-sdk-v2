using System;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class MissingImagesProductLevel : IMissingImagesProductLevel
    {
        public long MissingImages { get; set; }

        public long Total { get; set; }
    }
}
