using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.EnumAttribute))]
    public partial interface IEnumAttribute : IAttribute
    {
        string Value { get; set; }
    }
}
