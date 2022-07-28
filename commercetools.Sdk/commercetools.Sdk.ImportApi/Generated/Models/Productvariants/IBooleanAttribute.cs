using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.BooleanAttribute))]
    public partial interface IBooleanAttribute : IAttribute
    {
        bool Value { get; set; }

    }
}
