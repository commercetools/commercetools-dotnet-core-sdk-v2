using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class TextLineItemValue : ITextLineItemValue
    {
        public string Id { get; set; }

        public ILocalizedString Name { get; set; }
    }
}
