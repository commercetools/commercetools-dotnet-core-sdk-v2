

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class FieldDefinition : IFieldDefinition
    {
        public IFieldType Type { get; set; }

        public string Name { get; set; }

        public ILocalizedString Label { get; set; }

        public ITextInputHint InputHint { get; set; }
    }
}
