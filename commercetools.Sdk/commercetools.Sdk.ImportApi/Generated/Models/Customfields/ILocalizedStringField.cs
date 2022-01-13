using commercetools.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.LocalizedStringField))]
    public partial interface ILocalizedStringField : ICustomField
    {
        ILocalizedString Value { get; set; }
    }
}
