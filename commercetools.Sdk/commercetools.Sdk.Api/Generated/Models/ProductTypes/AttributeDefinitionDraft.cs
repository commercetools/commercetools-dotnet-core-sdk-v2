using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class AttributeDefinitionDraft : IAttributeDefinitionDraft
    {
        public IAttributeType Type { get; set;}
        
        public string Name { get; set;}
        
        public ILocalizedString Label { get; set;}
        
        public bool IsRequired { get; set;}
        
        public IAttributeConstraintEnum AttributeConstraint { get; set;}
        
        public ILocalizedString InputTip { get; set;}
        
        public ITextInputHint InputHint { get; set;}
        
        public bool? IsSearchable { get; set;}
    }
}
