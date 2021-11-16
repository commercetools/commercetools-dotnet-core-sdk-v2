using System;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class AttributeDefinition : IAttributeDefinition
    {
        public Object Type { get; set;}
        
        public string Name { get; set;}
        
        public ILocalizedString Label { get; set;}
        
        public bool IsRequired { get; set;}
        
        public IAttributeConstraintEnum AttributeConstraint { get; set;}
        
        public ILocalizedString InputTip { get; set;}
        
        public ITextInputHint InputHint { get; set;}
        
        public bool IsSearchable { get; set;}
    }
}
