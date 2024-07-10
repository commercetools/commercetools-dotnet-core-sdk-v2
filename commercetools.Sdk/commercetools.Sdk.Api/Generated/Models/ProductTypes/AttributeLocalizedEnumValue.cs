using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class AttributeLocalizedEnumValue : IAttributeLocalizedEnumValue
    {
        public string Key { get; set; }

        public ILocalizedString Label { get; set; }
    }
}
