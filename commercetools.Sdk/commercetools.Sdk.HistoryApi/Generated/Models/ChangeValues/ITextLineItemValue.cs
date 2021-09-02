using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.TextLineItemValue))]
    public partial interface ITextLineItemValue
    {
        string Id { get; set; }

        ILocalizedString Name { get; set; }
    }
}
