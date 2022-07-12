using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetProductCountChange))]
    public partial interface ISetProductCountChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        int PreviousValue { get; set; }

        int NextValue { get; set; }
    }
}
