using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetCategoryOrderHintChange))]
    public partial interface ISetCategoryOrderHintChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string CatalogData { get; set; }

        string CategoryId { get; set; }

        ICategoryOrderHints PreviousValue { get; set; }

        ICategoryOrderHints NextValue { get; set; }
    }
}
