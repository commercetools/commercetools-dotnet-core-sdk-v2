using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangePlainEnumValueLabelChange))]
    public partial interface IChangePlainEnumValueLabelChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string PreviousValue { get; set; }

        string NextValue { get; set; }

        string AttributeName { get; set; }

        string ValueKey { get; set; }

    }
}
