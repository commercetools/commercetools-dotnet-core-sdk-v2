using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Labels
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Labels.StringLabel))]
    public partial interface IStringLabel : ILabel
    {
        new string Type { get; set; }

        string Value { get; set; }
    }
}
