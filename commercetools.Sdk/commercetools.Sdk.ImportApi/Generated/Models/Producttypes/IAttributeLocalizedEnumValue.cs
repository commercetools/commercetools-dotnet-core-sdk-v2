using commercetools.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Producttypes
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Producttypes.AttributeLocalizedEnumValue))]
    public partial interface IAttributeLocalizedEnumValue
    {
        string Key { get; set; }

        ILocalizedString Label { get; set; }
    }
}
