using commercetools.Sdk.MLApi.Models.Common;
using System;


namespace commercetools.Sdk.MLApi.Models.SimilarProducts
{

    public partial class SimilarProductsTaskStatus : ISimilarProductsTaskStatus
    {
        public ITaskStatusEnum State { get; set; }

        public DateTime? Expires { get; set; }

        public ISimilarProductsPagedQueryResult Result { get; set; }
    }
}
