using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class MissingImagesSearchRequest : IMissingImagesSearchRequest
    {
        public long? Limit { get; set; }

        public long? Offset { get; set; }

        public bool? Staged { get; set; }

        public long? ProductSetLimit { get; set; }

        public bool? IncludeVariants { get; set; }

        public bool? AutoThreshold { get; set; }

        public long? Threshold { get; set; }

        public IList<string> ProductIds { get; set; }
        public IEnumerable<string> ProductIdsEnumerable { set => ProductIds = value.ToList(); }


        public IList<string> ProductTypeIds { get; set; }
        public IEnumerable<string> ProductTypeIdsEnumerable { set => ProductTypeIds = value.ToList(); }

    }
}
