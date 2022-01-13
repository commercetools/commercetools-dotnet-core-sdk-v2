using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class FieldDefinitionOrderValue : IFieldDefinitionOrderValue
    {
        public string Name { get; set; }

        public ILocalizedString Label { get; set; }
    }
}
