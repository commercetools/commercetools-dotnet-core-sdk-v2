using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeEnumValueLabelChange))]
    public partial interface IChangeEnumValueLabelChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string FieldName { get; set; }

        string ValueKey { get; set; }

        string PreviousValue { get; set; }

        string NextValue { get; set; }

    }
}
