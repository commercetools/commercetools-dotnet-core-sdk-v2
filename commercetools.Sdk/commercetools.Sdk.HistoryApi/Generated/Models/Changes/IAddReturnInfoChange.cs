using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddReturnInfoChange))]
    public partial interface IAddReturnInfoChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IReturnInfo NextValue { get; set; }
    }
}
