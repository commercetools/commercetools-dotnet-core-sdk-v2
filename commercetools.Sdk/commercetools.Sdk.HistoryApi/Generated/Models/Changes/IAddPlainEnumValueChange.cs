using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddPlainEnumValueChange))]
    public partial interface IAddPlainEnumValueChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IEnumValue NextValue { get; set; }

        string AttributeName { get; set; }

    }
}
