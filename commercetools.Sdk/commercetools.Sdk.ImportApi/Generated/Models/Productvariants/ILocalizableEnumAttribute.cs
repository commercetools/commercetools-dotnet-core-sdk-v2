using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.LocalizableEnumAttribute))]
    public partial interface ILocalizableEnumAttribute : IAttribute
    {
        string Value { get; set;}
    }
}
