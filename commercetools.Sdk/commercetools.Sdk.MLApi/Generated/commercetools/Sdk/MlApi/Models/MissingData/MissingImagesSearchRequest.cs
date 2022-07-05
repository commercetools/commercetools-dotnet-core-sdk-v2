using System.Collections.Generic;


namespace commercetools.Sdk.MLApi.Models.MissingData
{

    public partial class MissingImagesSearchRequest : IMissingImagesSearchRequest
    {
        public long? Limit { get; set; }

        public long? Offset { get; set; }

        public bool? Staged { get; set; }

        public long? ProductSetLimit { get; set; }

        public bool? IncludeVariants { get; set; }

        public bool? AutoThreshold { get; set; }

        public long? Threshold { get; set; }

        public List<string> ProductIds { get; set; }

        public List<string> ProductTypeIds { get; set; }
    }
}
