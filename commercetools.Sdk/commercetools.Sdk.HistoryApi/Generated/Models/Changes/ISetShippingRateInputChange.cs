using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetShippingRateInputChange))]
    public partial interface ISetShippingRateInputChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        Object NextValue { get; set; }

        Object PreviousValue { get; set; }
    }
}
