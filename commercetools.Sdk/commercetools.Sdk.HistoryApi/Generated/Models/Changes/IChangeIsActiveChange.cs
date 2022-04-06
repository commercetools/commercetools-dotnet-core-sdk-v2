using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeIsActiveChange))]
    public partial interface IChangeIsActiveChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        bool PreviousValue { get; set; }

        bool NextValue { get; set; }
    }
}
