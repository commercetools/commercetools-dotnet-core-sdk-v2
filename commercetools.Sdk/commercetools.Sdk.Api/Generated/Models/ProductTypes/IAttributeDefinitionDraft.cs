using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.AttributeDefinitionDraft))]
    public partial interface IAttributeDefinitionDraft 
    {
        IAttributeType Type { get; set;}
        
        string Name { get; set;}
        
        ILocalizedString Label { get; set;}
        
        bool IsRequired { get; set;}
        
        IAttributeConstraintEnum AttributeConstraint { get; set;}
        
        ILocalizedString InputTip { get; set;}
        
        ITextInputHint InputHint { get; set;}
        
        bool? IsSearchable { get; set;}
    }
}
