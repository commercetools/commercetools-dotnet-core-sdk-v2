using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableEnumAttribute))]
    public partial interface ILocalizableEnumAttribute : IAttribute
    {
        string Value { get; set; }

    }
}
