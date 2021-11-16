using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.AttributeLocalizedEnumValue))]
    public partial interface IAttributeLocalizedEnumValue 
    {
        string Key { get; set;}
        
        ILocalizedString Label { get; set;}
    }
}
