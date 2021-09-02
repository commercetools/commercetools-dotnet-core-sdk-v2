using commercetools.HistoryApi.Models.Common;
using commercetools.HistoryApi.Models.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Labels
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Labels.ProductLabel))]
    public partial interface IProductLabel : ILabel
    {
        new string Type { get; set; }

        ILocalizedString Slug { get; set; }

        ILocalizedString Name { get; set; }
    }
}
