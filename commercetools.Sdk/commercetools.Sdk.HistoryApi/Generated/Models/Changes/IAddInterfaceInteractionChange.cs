using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddInterfaceInteractionChange))]
    public partial interface IAddInterfaceInteractionChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ICustomFieldExpandedValue NextValue { get; set; }

    }
}
