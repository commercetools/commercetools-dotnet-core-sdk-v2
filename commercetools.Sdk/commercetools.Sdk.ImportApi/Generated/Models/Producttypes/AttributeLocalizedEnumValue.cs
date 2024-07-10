using commercetools.Sdk.ImportApi.Models.Common;


namespace commercetools.Sdk.ImportApi.Models.Producttypes
{

    public partial class AttributeLocalizedEnumValue : IAttributeLocalizedEnumValue
    {
        public string Key { get; set; }

        public ILocalizedString Label { get; set; }
    }
}
