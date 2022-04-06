using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    public partial class FieldDefinitionOrderValue : IFieldDefinitionOrderValue
    {
        public string Name { get; set; }

        public ILocalizedString Label { get; set; }
    }
}
