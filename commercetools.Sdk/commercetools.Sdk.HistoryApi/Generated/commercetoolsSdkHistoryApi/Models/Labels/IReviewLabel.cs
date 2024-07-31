using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
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
