using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetTextLineItemCustomTypeChange))]
    public partial interface ISetTextLineItemCustomTypeChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ITextLineItemValue TextLineItem { get; set; }

        ICustomFields NextValue { get; set; }

        ICustomFields PreviousValue { get; set; }
    }
}
