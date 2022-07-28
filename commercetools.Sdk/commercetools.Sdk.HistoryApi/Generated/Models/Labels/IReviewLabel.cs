using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Labels
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Labels.ReviewLabel))]
    public partial interface IReviewLabel : ILabel
    {
        new string Type { get; set; }

        string Key { get; set; }

        string Title { get; set; }

    }
}
