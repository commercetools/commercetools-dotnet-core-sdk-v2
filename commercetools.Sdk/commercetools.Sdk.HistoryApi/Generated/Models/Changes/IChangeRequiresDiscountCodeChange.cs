using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeRequiresDiscountCodeChange))]
    public partial interface IChangeRequiresDiscountCodeChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        bool PreviousValue { get; set; }

        bool NextValue { get; set; }

    }
}
