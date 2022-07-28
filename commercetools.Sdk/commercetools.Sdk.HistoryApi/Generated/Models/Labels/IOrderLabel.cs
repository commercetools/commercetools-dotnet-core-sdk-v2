using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Labels
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Labels.OrderLabel))]
    public partial interface IOrderLabel : ILabel
    {
        new string Type { get; set; }

        string CustomerEmail { get; set; }

        string OrderNumber { get; set; }

    }
}
