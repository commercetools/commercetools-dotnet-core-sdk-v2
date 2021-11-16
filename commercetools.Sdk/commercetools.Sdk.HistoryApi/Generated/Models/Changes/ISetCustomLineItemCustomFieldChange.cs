using commercetools.HistoryApi.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetCustomLineItemCustomFieldChange))]
    public partial interface ISetCustomLineItemCustomFieldChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string Name { get; set; }

        ILocalizedString CustomLineItem { get; set; }

        Object NextValue { get; set; }

        Object PreviousValue { get; set; }
    }
}
