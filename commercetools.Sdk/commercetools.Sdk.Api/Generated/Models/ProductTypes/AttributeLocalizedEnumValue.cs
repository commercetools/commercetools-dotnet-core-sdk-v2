using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class AttributeLocalizedEnumValue : IAttributeLocalizedEnumValue
    {
        public string Key { get; set;}
        
        public ILocalizedString Label { get; set;}
    }
}
