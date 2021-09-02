using commercetools.MLApi.Models.Common;
using commercetools.MLApi.Models.SimilarProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.SimilarProducts
{
    public partial class SimilarProductsTaskStatus : ISimilarProductsTaskStatus
    {
        public ITaskStatusEnum State { get; set; }

        public DateTime? Expires { get; set; }

        public ISimilarProductsPagedQueryResult Result { get; set; }
    }
}
