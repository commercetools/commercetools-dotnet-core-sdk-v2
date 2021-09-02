using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetCategoryOrderHintChange : ISetCategoryOrderHintChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string CatalogData { get; set; }

        public string CategoryId { get; set; }

        public ICategoryOrderHints PreviousValue { get; set; }

        public ICategoryOrderHints NextValue { get; set; }
        public SetCategoryOrderHintChange()
        {
            this.Type = "SetCategoryOrderHintChange";
        }
    }
}
