using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Labels
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Labels.StringLabel))]
    public partial interface IStringLabel : ILabel
    {
        new string Type { get; set; }

        string Value { get; set; }

    }
}
