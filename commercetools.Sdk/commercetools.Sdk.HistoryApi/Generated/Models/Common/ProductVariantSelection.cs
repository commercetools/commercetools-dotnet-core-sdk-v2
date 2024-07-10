using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ProductVariantSelection : IProductVariantSelection
    {
        public IProductVariantSelectionTypeEnum Type { get; set; }

        public IList<string> Skus { get; set; }
        public IEnumerable<string> SkusEnumerable { set => Skus = value.ToList(); }

    }
}
