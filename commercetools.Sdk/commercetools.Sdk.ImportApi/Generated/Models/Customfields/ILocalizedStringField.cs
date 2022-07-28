using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.LocalizedStringField))]
    public partial interface ILocalizedStringField : ICustomField
    {
        ILocalizedString Value { get; set; }

    }
}
