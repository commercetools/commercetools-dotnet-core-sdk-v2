using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomTypeChange))]
    public partial interface ISetCustomTypeChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ICustomFields NextValue { get; set; }

        ICustomFields PreviousValue { get; set; }

    }
}
