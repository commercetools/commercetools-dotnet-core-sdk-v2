using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeOrderStateChange))]
    public partial interface IChangeOrderStateChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IOrderState NextValue { get; set; }

        IOrderState PreviousValue { get; set; }
    }
}
