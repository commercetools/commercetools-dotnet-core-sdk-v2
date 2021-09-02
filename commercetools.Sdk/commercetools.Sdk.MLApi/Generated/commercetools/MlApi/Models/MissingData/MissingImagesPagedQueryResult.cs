using commercetools.MLApi.Models.MissingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
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
