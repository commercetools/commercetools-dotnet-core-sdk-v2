using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.CustomFieldLocalizedEnumValue))]
    public partial interface ICustomFieldLocalizedEnumValue
    {
        string Key { get; set; }

        ILocalizedString Label { get; set; }
    }
}
