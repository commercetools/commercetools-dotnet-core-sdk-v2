using System.Collections.Generic;


namespace commercetools.Sdk.MLApi.Models.MissingData
{

    public partial class MissingImagesPagedQueryResult : IMissingImagesPagedQueryResult
    {
        public long Count { get; set; }

        public long Total { get; set; }

        public long Offset { get; set; }

        public List<IMissingImages> Results { get; set; }

        public IMissingImagesMeta Meta { get; set; }
    }
}
