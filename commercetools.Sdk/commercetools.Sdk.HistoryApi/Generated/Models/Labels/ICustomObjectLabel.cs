using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Labels
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Labels.CustomObjectLabel))]
    public partial interface ICustomObjectLabel : ILabel
    {
        new string Type { get; set; }

        string Key { get; set; }

        string Container { get; set; }
    }
}
