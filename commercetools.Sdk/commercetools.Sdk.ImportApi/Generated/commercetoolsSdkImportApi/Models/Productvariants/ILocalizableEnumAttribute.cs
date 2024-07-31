using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableEnumAttribute))]
    public partial interface ILocalizableEnumAttribute : IAttribute
    {
        string Value { get; set; }

    }
}
