using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeIsSearchableChange))]
    public partial interface IChangeIsSearchableChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string AttributeName { get; set; }

        bool NextValue { get; set; }

        bool PreviousValue { get; set; }
    }
}
