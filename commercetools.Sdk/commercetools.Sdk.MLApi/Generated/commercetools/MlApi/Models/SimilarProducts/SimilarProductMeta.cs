using commercetools.MLApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.SimilarProducts
{
    public partial class SimilarProductMeta : ISimilarProductMeta
    {
        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public IMoney Price { get; set; }

        public long? VariantCount { get; set; }
    }
}
