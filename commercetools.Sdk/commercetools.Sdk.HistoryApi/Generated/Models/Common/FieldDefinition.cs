using System;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class FieldDefinition : IFieldDefinition
    {
        public Object Type { get; set;}
        
        public string Name { get; set;}
        
        public ILocalizedString Label { get; set;}
        
        public ITextInputHint InputHint { get; set;}
    }
}
