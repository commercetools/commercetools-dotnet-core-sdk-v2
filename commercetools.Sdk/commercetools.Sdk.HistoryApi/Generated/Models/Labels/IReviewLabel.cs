using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Labels
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Labels.ReviewLabel))]
    public partial interface IReviewLabel : ILabel
    {
        new string Type { get; set; }

        string Key { get; set; }

        string Title { get; set; }
    }
}
