using commercetools.HistoryApi.Models.Common;
using commercetools.HistoryApi.Models.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Labels
{
    public partial class ProductLabel : IProductLabel
    {
        public string Type { get; set; }

        public ILocalizedString Slug { get; set; }

        public ILocalizedString Name { get; set; }
        public ProductLabel()
        {
            this.Type = "ProductLabel";
        }
    }
}
