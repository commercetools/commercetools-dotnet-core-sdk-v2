using commercetools.ImportApi.Models.Common;


namespace commercetools.ImportApi.Models.Producttypes
{
    public partial class AttributeLocalizedEnumValue : IAttributeLocalizedEnumValue
    {
        public string Key { get; set;}
        
        public ILocalizedString Label { get; set;}
    }
}
