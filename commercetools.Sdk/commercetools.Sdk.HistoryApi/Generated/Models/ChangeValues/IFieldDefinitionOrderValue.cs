using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.FieldDefinitionOrderValue))]
    public partial interface IFieldDefinitionOrderValue
    {
        string Name { get; set; }

        ILocalizedString Label { get; set; }

    }
}
