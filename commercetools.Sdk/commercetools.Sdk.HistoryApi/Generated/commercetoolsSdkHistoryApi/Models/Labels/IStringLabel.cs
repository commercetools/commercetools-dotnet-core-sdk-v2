using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Labels
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Labels.StringLabel))]
    public partial interface IStringLabel : ILabel
    {
        new string Type { get; set; }

        string Value { get; set; }

    }
}
