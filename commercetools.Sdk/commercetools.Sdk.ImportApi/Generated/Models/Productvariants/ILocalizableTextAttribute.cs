using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableTextAttribute))]
    public partial interface ILocalizableTextAttribute : IAttribute
    {
        ILocalizedString Value { get; set; }

    }
}
