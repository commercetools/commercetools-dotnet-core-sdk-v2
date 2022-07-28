using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetSellerCommentChange))]
    public partial interface ISetSellerCommentChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string PreviousValue { get; set; }

        string NextValue { get; set; }

    }
}
