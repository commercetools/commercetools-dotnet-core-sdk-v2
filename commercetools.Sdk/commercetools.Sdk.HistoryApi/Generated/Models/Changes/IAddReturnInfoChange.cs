using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.AddReturnInfoChange))]
    public partial interface IAddReturnInfoChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IReturnInfo NextValue { get; set; }
    }
}
