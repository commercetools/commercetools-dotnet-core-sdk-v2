using commercetools.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.LocalizableTextAttribute))]
    public partial interface ILocalizableTextAttribute : IAttribute
    {
        ILocalizedString Value { get; set;}
    }
}
