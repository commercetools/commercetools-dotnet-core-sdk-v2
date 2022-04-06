using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Labels
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Labels.CustomObjectLabel))]
    public partial interface ICustomObjectLabel : ILabel
    {
        new string Type { get; set; }

        string Key { get; set; }

        string Container { get; set; }
    }
}
